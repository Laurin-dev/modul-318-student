using System;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id, DateTime dateTime);
        Connections GetConnections(string fromStation, string toStattion, int tolimit, DateTime time, DateTime date);
    }
}