public class Customer{
    private string _name; 
    public Address _address;
    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }
    public string IsUSA(){
        if ( _address.IsUSA() == true){
           return "Yes"; 
        }     
        return "No";
    }
    public string GetCustomerName(){
        return _name;
    }
}