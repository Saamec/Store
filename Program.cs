

IDProduct<string> erger = new IDProduct<string>("ПM-003", "Плюшевый мишка", 1500, "игрушка");
IDProduct<int> erger2 = new IDProduct<int>(86, "Удивительная природа России", 2100, "книга");

Warehouse<Product>.ADD(erger);
Warehouse<Product>.ADD(erger2);



int SumOrder(List<Product> arrayGoods)
{
    int sum = 0;
    for (int i = 0; i < Warehouse<Product>.arrayGoods.ToArray().Length; i++)
    {
        sum += Warehouse<Product>.arrayGoods[i].Cost;
    }
    Console.WriteLine(sum);
    return sum;
}
SumOrder(Warehouse<Product>.arrayGoods);



public class Product
{
    internal string Name { get; set; }
    internal int Cost { get; set; }

    internal Product(string name, int cost)
    { 
        Name = name;
        Cost = cost;
    }

}

public class IDProduct <T>: Product
{
    string typeProduct { get; set; }
    T IDproduct { get; set; }

    internal IDProduct(T IDproduct, string Name, int Cost, string typeProduct) : base(Name, Cost)
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

public abstract class Bayer
{
    string Name;
    string Adress;
    string Email;

    internal abstract string Purchase(List<Product> list);
    internal abstract bool Payment();
    
}

