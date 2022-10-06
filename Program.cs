

StringIDProduct erger = new StringIDProduct("wefw", "wrgwg", 129, "toy");
Warehouse.arrayStr.Add(erger);


public abstract class Product<TID>
{
    protected TID IDProduct { get; set; }
    protected string Name { get; set; }
    protected int Cost { get; set; }

    protected Product(TID idPoduct, string name, int cost)
    {
        IDProduct = idPoduct;
        Name = name;
        Cost = cost;
    }

    protected Product()
    {
       
    }
}

public class StringIDProduct : Product<String>
{
    string typeProduct { get; set; }
    internal  StringIDProduct(string IDproduct, string Name, int Cost, string typeProduct) : base(IDproduct, Name, Cost)
    {
        this.typeProduct = typeProduct; 
    }
}

public class IntIDProduct : Product<int>
{
    string typeProduct { get; set; }
    internal IntIDProduct(int IDproduct, string Name, int Cost, string typeProduct) : base(IDproduct, Name, Cost)
    {
        this.typeProduct = typeProduct;
    }
}



public static class Warehouse 
{
    internal static List<Product<int>> arrayInt = new List<Product<int>>();
    internal static List<Product<string>> arrayStr = new List<Product<string>>();
}

