using System;

namespace HomeWork10
{
    internal class Program
    {
        static void Main()
        {
            var doctorService = new HomeWork10.Service.DoctroService();
            var doctors = doctorService.Doctors();

            var doctorController = new HomeWork10.Controller.DoctorController();
            var startDate = new DateTime(1993, 05, 25);
            var endDate = new DateTime(2002, 12, 15);

            doctorController.DoctorsBornBetweenDates(startDate, endDate, doctors);
        }
    }
}
