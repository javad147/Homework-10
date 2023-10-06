using System;
using HomeWork10.Models;

namespace HomeWork10.Controller
{
    internal class DoctorController
    {
        public void DoctorsBornBetweenDates(DateTime startDate, DateTime endDate, Doctor[] doctors)
        {
            Console.WriteLine($"Doktorlarin dogum tarixi araligi: {startDate.ToString("dd.MM.yyyy")} and {endDate.ToString("dd.MM.yyyy")}");

            foreach (var doctor in doctors)
            {
                if (doctor.Birthday >= startDate && doctor.Birthday <= endDate)
                {
                    Console.WriteLine($"{doctor.FirstName} {doctor.LastName}");
                }
            }
        }
    }
}
