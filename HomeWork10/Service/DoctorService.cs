using HomeWork10.Models;

namespace HomeWork10.Service
{
    internal class DoctroService
    {
        public Doctor[] Doctors()
        {
            Doctor doctor1 = new()
            {
                Id = 1,
                FirstName = "Javad",
                LastName = "Bakirli",
                Adress = "Binagadi",
                Birthday = new(1993, 05, 25)
            };

            Doctor doctor2 = new()
            {
                Id = 2,
                FirstName = "Zaur",
                LastName = "Alakbarov",
                Adress = "Novxani",
                Birthday = new(2001, 04, 11)
            };

            Doctor doctor3 = new()
            {
                Id = 3,
                FirstName = "Emin",
                LastName = "Aliyev",
                Adress = "Ahmedli",
                Birthday = new(2003, 10, 11)
            };

            Doctor doctor4 = new()
            {
                Id = 4,
                FirstName = "Kainat",
                LastName = "Qulizada",
                Adress = "Nizami",
                Birthday = new(2002, 05, 15)
            };

            return new Doctor[] { doctor1, doctor2, doctor3, doctor4 };
        }
    }
}
