public class Order{
    public List<Product> listOfProducts = new List<Product>();
    private Customer _customer;
    public Order (Customer customer){
        _customer = customer;
    } 
    public void GetTotalCost(){
        double index = 0;
        foreach (Product product in listOfProducts)
        {
            double tuki = product.PriceOfProduct();
            index = index + tuki;
        }
        Console.WriteLine($"Total Cost : {index + GetShippingCost()}");
        Console.WriteLine();  
    }
    public void GetPackagingLabel(){
         foreach (Product product in listOfProducts)
        {
            Console.WriteLine($"Product Name : {product.GetName()}");
            Console.WriteLine($"Product ID : {product.GetId()}");
        }
    }
    public void GetShippingLabel(){
       Console.WriteLine($"Customer Name: {_customer.GetCustomerName()}");
       Console.WriteLine($"Customer Address: {_customer._address.DisplayAddress()}");
    }

    public double GetShippingCost(){
        if ( _customer.IsUSA() == "Yes"){
            return 5;
        }
        return 35;
    }
}
