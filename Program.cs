


public  class Product<TID>
{
    public TID IDProduct { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Cost { get; set; }

    Product(TID idPoduct, string name, string description, int cost)
    {
        IDProduct = idPoduct;
        Name = name;
        Description = description;
        Cost = cost;
    }
}

public class Toys : Product
{

}




public class Warehouse
{
    //Product[] array = new Product[100];
        
}