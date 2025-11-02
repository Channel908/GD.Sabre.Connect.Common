namespace GD.Sabre.Connect.Common.Service;

public interface ISabreAirAvail
{
    Task<OTA_AirAvailRS> AirAvail(string token);
}
