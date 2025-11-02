using GD.Sabre.Common.Models.AirAvail;

namespace GD.Sabre.Connect.Common.Service;

public static class SabreAirAvailExtensions
{

    public static AirAvailResponseModel? ToModel(this OTA_AirAvailRS? response)
    {
        if(response?.OriginDestinationOptions == null) return null;

        var model = new AirAvailResponseModel
        {
            Success = response?.ApplicationResults?.Success != null && response?.OriginDestinationOptions?.OriginDestinationOption != null,
            HostCommand = response?.ApplicationResults?.Warning?[0]?.SystemSpecificResults?[0]?.HostCommand?.Value,

            OriginDestinations = new OriginDestinations
            {
                DestinationTimeZone = response?.OriginDestinationOptions?.DestinationTimeZone,
                OriginTimeZone = response?.OriginDestinationOptions?.OriginTimeZone,
            },

            TimeStamp = DateTime.UtcNow,
        };

        if(response?.OriginDestinationOptions!.OriginDestinationOption is null)
            return model;

        var itineraries = new List<FlightItinerary>();

        foreach (var od in response!.OriginDestinationOptions!.OriginDestinationOption)
        {
            var itinerary = new FlightItinerary { RPH = od.RPH.ToInt() };

            var flightSegments = new List<FlightSegment>();

            foreach(var seg in od.FlightSegment)
            {
                var flightSegment = new FlightSegment
                {
                    RPH = seg.RPH.ToInt(),
                    ArrivalDateTime = seg.ArrivalDateTime.AddYear(),
                    DepartureDateTime = seg.DepartureDateTime.AddYear(),
                    OriginCode = seg.OriginLocation.LocationCode,
                    DestinationCode = seg.DestinationLocation.LocationCode,
                    EquipmentCode = seg.Equipment?.AirEquipType,
                    FlightNumber = seg.FlightNumber,
                    NumberOfStops = seg.StopQuantity?.ToInt() ?? 0,

                    MarketingAirline = new FlightSegmentAirlineDetails 
                     { 
                         Code = seg.MarketingAirline?.Code ?? string.Empty,
                         FlightNumber = seg.MarketingAirline?.FlightNumber ?? string.Empty,
                     },

                    OperatingAirline = new FlightSegmentAirlineDetails
                    {
                        Code = seg.OperatingAirline?.Code ?? string.Empty,
                    },
                    
                    BookingClassAvailabilies = GetClasses(seg.BookingClassAvail),
                    MealCodes = GetMealCodes(seg.Meal),
                    TrafficRestrictionCode = seg.FlightDetails?.TrafficRestrictionCode,
                    TotalTravelTime = seg.FlightDetails?.TotalTravelTime?.ToInt() ?? 0,
                    GroundTime = seg.FlightDetails?.GroundTime?.ToInt() ?? 0,
                    ETicket = seg.eTicket,
                    DOTIndicator = seg.DOT_Ind,
                    DaysOfOperation = GetDayofOperation(seg.DaysOfOperation),
                    ConnectionIndicator = seg.ConnectionInd,
                    Charter = seg.FlightDetails?.Charter,
                    Cancelled = seg.FlightDetails?.Canceled,
                };

                flightSegments.Add(flightSegment);
            }
            
            itinerary.FlightSegments = flightSegments;
            itineraries.Add(itinerary);

        }

        model.OriginDestinations.Itineraries = itineraries;


        return model;

        DaysOfOperation? GetDayofOperation(OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDaysOfOperation? dop)
        {
            if (dop?.OperationSchedule?.OperationTimes?.OperationTime is null) return null;

            return new DaysOfOperation
            {
                Monday = dop?.OperationSchedule?.OperationTimes?.OperationTime?.Mon,
                Tuesday = dop?.OperationSchedule?.OperationTimes?.OperationTime?.Tue,
                Wednesday = dop?.OperationSchedule?.OperationTimes?.OperationTime?.Weds,
                Thursday = dop?.OperationSchedule?.OperationTimes?.OperationTime?.Thur,
                Friday = dop?.OperationSchedule?.OperationTimes?.OperationTime?.Fri,
                Saturday = dop?.OperationSchedule?.OperationTimes?.OperationTime?.Sat,
                Sunday = dop?.OperationSchedule?.OperationTimes?.OperationTime?.Sun,
            };
        }

        List<FlightSegmentMealCode> GetMealCodes(OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentMeal[]? meals)
        {
            if (meals is null) return [];
            if (meals.Length == 0) return [];

            return meals.Select(x => new FlightSegmentMealCode { Code = x.MealCode }).ToList();

        }

        List<BookingClassAvailability> GetClasses(OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentBookingClassAvail[]? classes)
        {
            if (classes is null) return [];
            if (classes.Length == 0) return [];

            return classes.Select(x => new BookingClassAvailability
            {
                RPH = x.RPH.ToInt(),
                Availability = x.Availability.ToInt(),
                BookingCode = x.ResBookDesigCode,
                BrandId = x.BrandID
            }).ToList();
        }

    }

    public static int ToInt(this string rph)
    {
        if (int.TryParse(rph, out int result))
            return result;

        return 0;
    }

    public static DateTime AddYear(this string dat)
    {
        var year = DateTime.Now.Year;
        var tempDate = DateTime.Parse($"{year}-{dat}");

        if (tempDate.Date < DateTime.Now.Date) return DateTime.Parse($"{year + 1}-{dat}");

        return tempDate;
    }

}
