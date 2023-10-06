using HomeWork10.Models;

namespace HomeWork10.Service
{
    internal class EmployeeService
    {
        public Employee[] Employees()
        {
            Employee employee1 = new Employee
            {
                Id = 1,
                FirstName = "Javad",
                LastName = "Bakirli",
                Age = 31,
                Salary = 2500,
            };

            Employee employee2 = new Employee
            {
                Id = 2,
                FirstName = "Zaur",
                LastName = "Alakbarov",
                Age = 23,
                Salary = 1000,
            };

            Employee employee3 = new Employee
            {
                Id = 3,
                FirstName = "Emin",
                LastName = "Aliyev",
                Age = 35,
                Salary = 1800,
            };

            Employee employee4 = new Employee
            {
                Id = 4,
                FirstName = "Kainat",
                LastName = "Qulizada",
                Age = 40,
                Salary = 1700,
            };

            return new Employee[] { employee1, employee2, employee3, employee4 };
        }
    }
}
