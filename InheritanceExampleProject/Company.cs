using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace InheritanceTask
{
    public class Company
    {
        private readonly Employee[] employees;


        public Company(Employee[] employees)
        {
            this.employees = employees;
        }

        public void GiveEverybodyBonus(decimal companyBonus)
        {
            foreach (Employee employee in employees)
            {
                employee.SetBonus(companyBonus);
            }
        }

        public decimal TotalToPay() => employees.Sum(emp => emp.ToPay());


        public string NameMaxSalary() => employees.OrderByDescending(emp => emp.ToPay()).First().Name;
    }
}