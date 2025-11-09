using GD.Sabre.Common;
using GD.Sabre.Common.Models.AirAvail;

namespace GD.Sabre.Connect.Common.Service;

public interface ISabreAirAvail
{
    Task<SabreResult<OTA_AirAvailRS>> AirAvail(AirAvailRequestModel request, string token);
    Task<SabreResult<OTA_AirAvailRS>> MoreAirAvail(string token);
}
