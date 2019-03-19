using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary.Models;
using MyClassLibrary.Enum;

namespace MyClassLibrary.Models
{
    public class Manager : Employee
    {

        private double Bonus { get; set; }

        public Manager(string firstname, string lastname, double salary) : base(firstname, lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
            Role = Role.Manager;
        }

        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
