using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentCollege.Models
{
    internal class Student:Person
    {
        public string Branch {  get; set; }
        public Student() { }

        public Student(int id,string address,DateOnly date,string branch):base(id,address,date)
        {
            Branch = branch;    
        }
        public override string PrintDetails()
        {
            return $"{base.PrintDetails()}\nBranch : {Branch}";
        }
    }
}
