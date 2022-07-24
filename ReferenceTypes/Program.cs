using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1; // değer eşitlemesi değil adres eşitlemesi yapıyorsun.
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "4645640";
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = new Person();
            person3 = customer;
            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(employee);
            personManager.Add(customer);
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
    }
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
    // Biz neden kalıtım kullanıyoruz? customera ihtiyacımız olduğunda customer kullanırız.Employeye ihtiyacımız olduğunda Employee kullanırız.
    // İşte bu yüzden kalıtım kullanırız.Add diye bir operasyonumuz olsun. Bu Add'i her class için mi oluşturacağız? Hayır. Bir tane Add
    // metodu oluştururuz. Buna base classtan kalıtılmış bütün classların referanslarını göndererek add işlemi yaparız.
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
