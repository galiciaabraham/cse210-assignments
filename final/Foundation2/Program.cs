using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Sing street","Cochabamba","Rio Grande","Bolivia",43435);
        Customer customer1 = new Customer("John Carter",address1);
        List<Product> products1 = new List<Product>{
            new Product("T-Shirt",143576,34.99f,4),
            new Product("Dress",347698,59.49f,1),
            new Product("Overall",347698,34.99f,2)
        };
        Order order1 = new Order(customer1,products1);

        Address address2 = new Address("777 E 2000 W","Park City","UT","United States",40505);
        Customer customer2 = new Customer("Josh Groovie",address2);
        List<Product> products2 = new List<Product>{
            new Product("Pants",14777,34.99f,1),
            new Product("Dress",347698,59.49f,1),
            new Product("Shoes",909000,70.00f,1)
        };
        Order order2 = new Order(customer2,products2);

        Address address3 = new Address("400 N 1900 E","Dream City","TX","United States",57789);
        Customer customer3 = new Customer("Will Gonzalez",address3);
        List<Product> products3 = new List<Product>{
            new Product("Gloves",78912,20.00f,2),
            new Product("Hat",343358,99.99f,1),
        };
        Order order3 = new Order(customer3,products3);

        Address address4 = new Address("Ote 150 N 112","Mexico City","Mexico City","Mexico",15530);
        Customer customer4 = new Customer("Roy Martinez",address4);
        List<Product> products4 = new List<Product>{
            new Product("Tie",649601,5.00f,10),
            new Product("Mat",509201,50.00f,1),
            new Product("Sunglasses",123401,15.00f,1)
        };
        Order order4 = new Order(customer4,products4);

        List<Order> orders = new List<Order>{
            order1,
            order2,
            order3,
            order4,
        };

        foreach(Order order in orders)
        {
            Console.WriteLine("");
            order.BuildPackingSlip();
            Console.WriteLine("");
            Console.WriteLine($"Your shipping was: ${order.CalculateShipping()}.00");
            Console.WriteLine($"Your grand-total was ${Math.Round(order.CalculateTotalPrice(),2)}");
            Console.WriteLine("");
            order.BuildShippingSlip();
            Console.WriteLine("");

        }
    }
}