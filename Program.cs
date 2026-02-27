using Gazizov.AirplaneProject;
using System;

class Program
{
    static void Main()
    {
        Airplane a = new Airplane("22", 22, 22, "fgdgg");
        a.TakeOff();
        a.Land();
        a.PerformPreFlightCheck();
        a.ShowInfo();
        a.CheckEngine();
        a.UpdateMaintenanceLog();

        Airplane b = new PassengerAirplane("Boeing 737-800", 160, 700, "Авиакомпания", 60, true);
        b.TakeOff();
        b.Land();
        b.PerformPreFlightCheck();
        b.ShowInfo();
        b.CheckEngine();
        b.UpdateMaintenanceLog();
    }
}