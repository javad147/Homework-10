using HomeWork10.Models;
using System;

namespace HomeWork10.Controller
{
    internal class EmployeeController
    {
        public void EmployeesWithSalaryRange(Employee[] employees, double minSalary, double maxSalary)
        {
            Console.WriteLine($"Ishcilerin mevacibi minimum {minSalary} maksimum {maxSalary}:");

            foreach (Employee employee in employees)
            {
                if (employee.Salary >= minSalary && employee.Salary <= maxSalary)
                {
                    Console.WriteLine($"Ad: {employee.FirstName}, Soyad: {employee.LastName}, Yash: {employee.Age}, Mevacib: {employee.Salary}");
                }
            }
        }
    }
}
