using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("9 de octubre","Guayaquil","Guayas","Ecuador");
        Customer customer1 = new Customer("Erick Bravo",address1);
        Order order1 = new Order(customer1);
        Product product11 = new Product("Teclado Gamer","123123",70.00,3);
        Product product12 = new Product("Mouse Gamer","321321",50.00,2);
        order1.listOfProducts.Add(product11);
        order1.listOfProducts.Add(product12);
        order1.GetShippingLabel();
        order1.GetPackagingLabel();
        order1.GetTotalCost();


        Address address2 = new Address("New Road","Panama City","Florida","USA");
        Customer customer2 = new Customer("Enrique Bravo",address2);
        Order order2 = new Order(customer2);
        Product product21 = new Product("Cannom Camera","000001",1200.00,1);
        Product product22 = new Product("Anera Headset","111111",80.00,2);
        order2.listOfProducts.Add(product21);
        order2.listOfProducts.Add(product22);
        order2.GetShippingLabel();
        order2.GetPackagingLabel();
        order2.GetTotalCost();

    }
}