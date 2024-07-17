using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentCollege.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateOnly DoB {  get; set; }

        public Person() { }

        public Person(int id,string address,DateOnly date)
        {
            Id = id;
            Address = address;
            DoB = date;
        }
        public virtual string PrintDetails()
        {
            return $"ID : {Id}\n" +
                $"Address : {Address}\n" +
                $"Date of Birth : {DoB}";
        }
    }
}
