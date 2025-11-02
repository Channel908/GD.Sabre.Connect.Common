using GD.Sabre.Common.Core;
using GD.Sabre.Common.Core.Factories;
using GD.Sabre.Common.Core.Models.Options;
using GD.Sabre.Common.Service.AAA;
using Microsoft.Extensions.Options;
using System.Security.Cryptography.Xml;

namespace GD.Sabre.Connect.Common.Service;

public class SabreAirAvail(IOptions<SabreServicesOptions> options,
        ISoapServiceFactory soapServiceFactory,
        IRequestHeaderBuilderFactory requestHeaderBuilderFactory) : SabreService(options, soapServiceFactory), ISabreAirAvail
{

    private readonly IOptions<SabreServicesOptions> _options =
      options ?? throw new ArgumentNullException(nameof(options));

    private readonly IRequestHeaderBuilderFactory _requestHeaderBuilderFactory = requestHeaderBuilderFactory ??
        throw new ArgumentNullException();


    public async Task<OTA_AirAvailRS> AirAvail(string token)
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

            OriginDestinationInformation = new OTA_AirAvailRQOriginDestinationInformation
            {
                FlightSegment = new OTA_AirAvailRQOriginDestinationInformationFlightSegment
                {
                    OriginLocation = new OTA_AirAvailRQOriginDestinationInformationFlightSegmentOriginLocation
                    {
                        LocationCode = "LON"
                    },
                    DestinationLocation = new OTA_AirAvailRQOriginDestinationInformationFlightSegmentDestinationLocation
                    {
                        LocationCode = "FRA"
                    },
                    DepartureDateTime = DateTime.Now.AddDays(10).ToString("yyyy-MM-dd"),
                    NumberInParty = "1",

                },
               
            },

            Version = "2.4.0"
           
        };

        var _soapService = CreateSabreSoapService()
                .WithHeaders(requestHeaders)
                .WithPayload(requestBody);

        var openSessionResponseBody = await _soapService.PostAsync<OTA_AirAvailRS>();
        return openSessionResponseBody;

    }


}
