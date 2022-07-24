using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Aslı",
                LastName = "Kurt"
            };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
    }
    // Attributes
    [ToTable("TblCustomers")]
    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty] // Bunun zorunlu olduğunu okuyabileceğim, onun için logic ekleyebileceğim bir yapı lazım.Bu yapı da reflection.
        // Attribute, reflection ile anlamlı olan bir şeydir.
        // Reflectionda şuna bakarız ; bir nesne oluşturulduğunda veya bir metod oluşturulduğunda hemen üstüne bakarız, üstünde bir attribute var mı ?
        // Attribute varsa, hangi attribute var?
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew()")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1},{2} added " , customer.Id,customer.FirstName,customer.LastName);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0}, {1},{2} added ", customer.Id, customer.FirstName, customer.LastName);
        }
    }
    [AttributeUsage(AttributeTargets.Property)] 
    class RequiredPropertyAttribute : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple =true)]
    class ToTableAttribute : Attribute
    {
        string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
