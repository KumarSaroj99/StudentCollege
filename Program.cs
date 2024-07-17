using studentCollege.Models;

namespace studentCollege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(100,"Thane (W)",new DateOnly(1990,09,21));
            Professor professor = new Professor(101,"Mulund",new DateOnly(1995,10,11),25000);
            Student student = new Student(102,"Navi Mumbai",new DateOnly(2000,08,27),"Computer Science");
            ShowDetails(person);
            ShowDetails(professor);
            ShowDetails(student);
        }
        static void ShowDetails(Person person)
        {
            Console.WriteLine($"========={person.GetType().Name}=========\n{person.PrintDetails()}");
        }
    }
}
