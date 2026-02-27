using Gazizov.AirplaneProject;
using System;

class Program
{
    static void Main()
    {
        PassengerAirplane Boeing = new PassengerAirplane("Boeing 737-800", 160, 700, "Авиакомпания", 60, true);
        Boeing.TakeOff();
        Boeing.Land();
        Boeing.PerformPreFlightCheck();
        Boeing.ShowInfo();
        Boeing.CheckEngine();
        Boeing.UpdateMaintenanceLog();

        Airplane Boe = new Airplane("22", 22, 22, "fgdgg");
        Boe.CheckEngine();
        Boe.UpdateMaintenanceLog();
    }
}