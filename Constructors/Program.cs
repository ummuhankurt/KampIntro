using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Id = 1, FirstName = "Engin",LastName = "Demirog",City = "Ankara"};
            Customer customer2 = new Customer ( 2, "Derin", "Demirog", "Ankara" );
            Console.WriteLine(customer2.FirstName);
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public Customer()
        {
            
        }
        public Customer(int id, string firstName, string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
    }
}
