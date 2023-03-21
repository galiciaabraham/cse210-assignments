using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("sing street","Panama");
        Customer customer1 = new Customer("Philis",address);

        Console.WriteLine(customer1.ReturnCustomer());
    }
}