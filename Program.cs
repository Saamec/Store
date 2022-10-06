

IDProduct<string> erger = new IDProduct<string>("ПM-003", "Плюшевый мишка", 1500, "игрушка");
IDProduct<int> erger2 = new IDProduct<int>(86, "Удивительная природа России", 2100, "книга");

Warehouse<Product>.ADD(erger);
Warehouse<Product>.ADD(erger2);

Person Vasya = new Person("Вася", "Москва", "hw44tru3@mail.ru");
List<Product> test = Vasya.Purchase(Warehouse<Product>.arrayGoods, 2);
Console.WriteLine(Vasya.Payment(test));



int SumOrder(List<Product> arrayGoods)
{
    int sum = 0;
    for (int i = 0; i < Warehouse<Product>.arrayGoods.Count; i++)
    {
        sum += Warehouse<Product>.arrayGoods[i].Cost;
    }
    Console.WriteLine(sum);
    return sum;
}
//SumOrder(Warehouse<Product>.arrayGoods);



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

    internal abstract List<Product> Purchase(List<Product> list, int count);
    internal abstract string Payment(List<Product> list);
    
}

public class Person : Bayer
{
    internal string Name { get; set; }
    internal string Address { get; set; }
    internal string Email { get; set; }

    internal Person (string name, string address, string email)
    {
        Name = name;
        Address = address;
        Email = email;
    }
    internal override List<Product> Purchase(List<Product> list, int count)
    {
        int bayRange = list.Count;
        Random random = new Random();
        List<Product> productList = new List<Product>();    
        for(int i = 0; i < count; i++)
        {
            productList.Add(list[random.Next(0, bayRange)]);
        }
        return productList;
    }

    internal override string Payment(List<Product> list)
    {
        int count = 0;
        string str = "Покупатель " + Name + "\n" +
                     "Совершена покупка : \n";
        foreach (Product product in list)
        {
            str += product.Name + "\n";
            count += product.Cost;
        }
        str += "На общюю сумму " + count + "\n";

        return str;
    }

    
}

