

IDProduct<string> erger = new IDProduct<string>("wefw", "wrgwg", 129, "toy");
IDProduct<int> erger2 = new IDProduct<int>(86, "wrgwg", 129, "toy");

Warehouse<Product>.ADD(erger);
Warehouse<Product>.ADD(erger2);



public class Product
{
    internal string Name { get; set; }
    internal int Cost { get; set; }

    protected Product(string name, int cost)
    { 
        Name = name;
        Cost = cost;
    }

    protected Product()
    {
       
    }
}

public class IDProduct <T>: Product
{
    string typeProduct { get; set; }
    T IDproduct { get; set; }

    public IDProduct(T IDproduct, string Name, int Cost, string typeProduct) : base(Name, Cost)
    {
        this.typeProduct = typeProduct; 
        this.IDproduct = IDproduct;
    }
}



public static class Warehouse <T> where T : class
{
    internal static List<T> arrayGoods = new List<T>();

    internal static void ADD(T value)
    {
        arrayGoods.Add(value);
    }            
}

