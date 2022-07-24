using System;

namespace Inheritance
{
    // inheritance -------> class 
    // implements---------> interface
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[2]
            {
                new Student{ Id = 1 , Department = "Computer Engineering", FirstName = "Ali"},
                new Customer{Id = 1, FirstName = "Engin Bey", FishNo  ="12345"}
            };
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }

    class Customer : Person
    {
        public string FishNo { get; set; }
    }
}
