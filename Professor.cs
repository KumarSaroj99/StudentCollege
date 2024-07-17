using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentCollege.Models
{
    internal class Professor:Person
    {
        public double Salary { get; set; }
        public Professor() { }

        public Professor(int id, string address, DateOnly date, int salary) : base(id, address, date)
        {
            Salary = salary;
        }
        public override string PrintDetails()
        {
            return $"{base.PrintDetails()}\nSalary : {Salary}";
        }
    }
}
