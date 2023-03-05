using Core.Abstract;
using Core.Concrete;
using Core.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        BaseCustomerManager customerManager = new NeroCustomerManager(new CustomerCheckManager());
        customerManager.Save(new Customer{DateOfBirth = new DateTime(1999,8,23), 
        FirstName = "Eda", LastName = "Buzlu", NationalityId = "12515613"});
    }
}