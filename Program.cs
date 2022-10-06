

StringIDProduct erger = new StringIDProduct("wefw", "wrgwg", 129, "toy");
Warehouse<StringIDProduct>.arrayGoods.Add(erger);
IntIDProduct tyty = new IntIDProduct(234, "wwgg", 567, "345r24");
Warehouse<IntIDProduct>.arrayGoods.Add(tyty);
Warehouse<Product<int>>.ADD(tyty);



public class Product<TID>
{
    internal TID IDProduct { get; set; }
    internal string Name { get; set; }
    internal int Cost { get; set; }

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
    public  StringIDProduct(string IDproduct, string Name, int Cost, string typeProduct) : base(IDproduct, Name, Cost)
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



public static class Warehouse <T> where T : class
{
    internal static List<T> arrayGoods = new List<T>();

    internal static void ADD(T value)
    {
        if (value is StringIDProduct) arrayGoods.Add(value);
    }            

}

