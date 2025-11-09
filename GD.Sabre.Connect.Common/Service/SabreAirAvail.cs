using GD.Sabre.Common;
using GD.Sabre.Common.Core;
using GD.Sabre.Common.Core.Factories;
using GD.Sabre.Common.Core.Models.Options;
using GD.Sabre.Common.Models.AirAvail;
using Microsoft.Extensions.Options;

namespace GD.Sabre.Connect.Common.Service;

public class SabreAirAvail(
    IOptions<SabreServicesOptions> options,
    ISoapServiceFactory soapServiceFactory,
    IRequestHeaderBuilderFactory requestHeaderBuilderFactory) : SabreService(options, soapServiceFactory), ISabreAirAvail
{
    private readonly IOptions<SabreServicesOptions> _options = options ?? throw new ArgumentNullException(nameof(options));

    private readonly IRequestHeaderBuilderFactory _requestHeaderBuilderFactory = requestHeaderBuilderFactory ?? throw new ArgumentNullException();

    private string? GetDateString(DateTime? d) => !d.HasValue ? null : d.Value.ToString("yyyy-MM-dd");
    
    public async Task<SabreResult<OTA_AirAvailRS>> MoreAirAvail(string token) => await AirAvail(null, token, true);

    public async Task<SabreResult<OTA_AirAvailRS>> AirAvail(AirAvailRequestModel request, string token) => await AirAvail(request, token, false);

    private async Task<SabreResult<OTA_AirAvailRS>> AirAvail(AirAvailRequestModel? request, string token, bool more = false)
    {
        try
        {
            var requestHeaders = _requestHeaderBuilderFactory.Create()
                     .WithBasicAuth(_options?.Organization() ?? throw new ArgumentException("Organization not supplied"))
                     .WithAction("OTA_AirAvailLLSRQ")
                     .WithService("OTA_AirAvailLLSRQ")
                     .WithToken(token)
                     .WithConversationId(Guid.NewGuid().ToString())
                     .WithCPAId(_options?.Organization() ?? throw new ArgumentException("Organization not supplied"))
                     .WithMessageId(Guid.NewGuid().ToString())
                     .Build();

            var requestBody = new OTA_AirAvailRQ
            {
                ReturnHostCommand = true,
                ReturnHostCommandSpecified = true,
                Version = "2.4.0"
            };

            if (more)
            {
                requestBody.OptionalQualifiers = new OTA_AirAvailRQOptionalQualifiers
                {
                    AdditionalAvailability = new OTA_AirAvailRQOptionalQualifiersAdditionalAvailability
                    {
                        Ind = true,
                        IndSpecified = true,
                    }
                };
            }

            else
            {
                if (request is null)
                    return SabreResult<OTA_AirAvailRS>.Failure("request mode is empty");

                requestBody.OriginDestinationInformation = new OTA_AirAvailRQOriginDestinationInformation
                {
                    FlightSegment = new OTA_AirAvailRQOriginDestinationInformationFlightSegment
                    {
                        OriginLocation = new OTA_AirAvailRQOriginDestinationInformationFlightSegmentOriginLocation
                        {
                            LocationCode = request.OriginLocationCode.Trim().ToUpper()
                        },
                        DestinationLocation = new OTA_AirAvailRQOriginDestinationInformationFlightSegmentDestinationLocation
                        {
                            LocationCode = request.DestinationLocationCode.Trim().ToUpper()
                        },

                        DepartureDateTime = GetDateString(request.DepartsAt),
                        ArrivalDateTime = GetDateString(request.ArrivesAt),

                        NumberInParty = request.NumberInParty.ToString(),
                    }
                };

                if (request.DirectFlights)
                {
                    requestBody.OptionalQualifiers ??= new OTA_AirAvailRQOptionalQualifiers();
                    requestBody.OptionalQualifiers.FlightQualifiers = new OTA_AirAvailRQOptionalQualifiersFlightQualifiers
                    {
                        DirectOnly = true,
                        DirectOnlySpecified = true,
                    };
                }

                if (request.DepartureTimeWindow.HasValue & request.DepartsAt.HasValue)
                {
                    var wtb = request.DepartsAt.Value.AddHours(-(request.DepartureTimeWindow.Value)).ToString("HH:mm");
                    var wta = request.DepartsAt.Value.AddHours(-(request.DepartureTimeWindow.Value)).ToString("HH:mm");

                    requestBody.OptionalQualifiers ??= new OTA_AirAvailRQOptionalQualifiers();

                    requestBody.OptionalQualifiers.TimeQualifiers ??= new OTA_AirAvailRQOptionalQualifiersTimeQualifiers
                    {
                        DepartureTime = new OTA_AirAvailRQOptionalQualifiersTimeQualifiersDepartureTime
                        {
                            WindowAfter = wta,
                            WindowBefore = wtb
                        }
                    };
                }

                if (request.ArrivalTimeWindow.HasValue && request.ArrivesAt.HasValue)
                {
                    var wtb = request.DepartsAt.Value.AddHours(-(request.ArrivalTimeWindow.Value)).ToString("HH:mm");
                    var wta = request.DepartsAt.Value.AddHours(-(request.ArrivalTimeWindow.Value)).ToString("HH:mm");

                    requestBody.OptionalQualifiers ??= new OTA_AirAvailRQOptionalQualifiers();

                    requestBody.OptionalQualifiers.TimeQualifiers ??= new OTA_AirAvailRQOptionalQualifiersTimeQualifiers
                    {
                        ArrivalTime = new OTA_AirAvailRQOptionalQualifiersTimeQualifiersArrivalTime
                        {
                            WindowAfter = wta,
                            WindowBefore = wtb
                        }
                    };
                }
            }

            var _soapService = CreateSabreSoapService()
                    .WithHeaders(requestHeaders)
                    .WithPayload(requestBody);

            var airAvailRs = await _soapService.PostAsync<OTA_AirAvailRS>();

            if (airAvailRs is null)
                return SabreResult<OTA_AirAvailRS>.Failure("Air Availability returned a null response");

            if (airAvailRs.ApplicationResults.Success is null && airAvailRs.ApplicationResults.Error != null)
                return SabreResult<OTA_AirAvailRS>.Failure(airAvailRs.ApplicationResults.Error);

            return SabreResult<OTA_AirAvailRS>.Success(airAvailRs);
        }
        catch (Exception ex)
        {
            return SabreResult<OTA_AirAvailRS>.Failure(ex);
        }
    }
}
