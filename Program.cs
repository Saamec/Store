

IDProduct<string> goods = new IDProduct<string>("ПM-003", "Плюшевый мишка", 1500, "игрушка");
IDProduct<int> goods2 = new IDProduct<int>(86, "Удивительная природа России", 2100, "книга");
IDProduct<string> goods3 = new IDProduct<string>("ПM-002", "Плюшевый чебурашка", 1100, "игрушка");
IDProduct<string> goods4 = new IDProduct<string>("ПM-001", "Кожаный слон", 1800, "игрушка");
IDProduct<string> goods5 = new IDProduct<string>("ПM-004", "Реплика АК-47", 2500, "игрушка");
IDProduct<string> goods6 = new IDProduct<string>("ПM-005", "Машина Камаз", 1500, "игрушка");


Warehouse<Product>.ADD(goods);    //заполнили склад
Warehouse<Product>.ADD(goods2);
Warehouse<Product>.ADD(goods3);
Warehouse<Product>.ADD(goods4);
Warehouse<Product>.ADD(goods5);
Warehouse<Product>.ADD(goods6);

ListPersons.ADD(new Person("Василий Иванович Сургучев", "г.Москва, пр.Ленинградский, д.48, кв.17", "hw44tru3@mail.ru"));
ListPersons.ADD(new Person("Абрамов Виталий Сергеевич", "г.Пушкин, ул. Яковлевская, д.45, кв.28", "dfhdh@mail.ru"));
ListPersons.ADD(new Person("Камолова Антонина Петровна", "г.Санкт-Петербург, пр.Ленина, д.2, кв.354", "jljfdgc@mail.ru"));
ListPersons.ADD(new Person("Сущев Иван Тимофеевич", "г.Донецк, ул.Спартаковская, д.93, кв.34", "4vgcdf4@mail.ru"));
ListPersons.ADD(new Person("Задумкина Любовь Николаевна", "г.Севастополь, ул.Леваневского, д.45, кв.45", "fsdgjkifgul@mail.ru"));
ListPersons.ADD(new Person("Никлин Валерий Сергеевич", "д. Выдрино, ул.Щеглова, д.1, кв.1", "arrrtF@mail.ru"));

Person Vasya = new Person("Василий Иванович Сургучев", "г.Москва, пр.Ленинградский, д.48, кв.17", "hw44tru3@mail.ru");
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



public static class Warehouse <T> where T : class            //Склад продукции
{
    internal static List<T> arrayGoods = new List<T>();
    

    internal static void ADD(T value)
    {
        arrayGoods.Add(value);
    }            
}

public static class ListPersons                              //Список зарегистрированных заказчиков
{
    internal static List<Person> arrayPersons = new List<Person>();
    
    internal static void ADD(Person person)
    {
        arrayPersons.Add(person);
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
        string str = "|Покупатель: " + Name + "| Адрес: " + Address + "| Почта: " + Email + "\n" +
                     "|Совершена покупка : \n|";
        foreach (Product product in list)
        {
            str += product.Name + "\n|";
            count += product.Cost;
        }
        str += "На общюю сумму " + count + "\n";

        return str;
    }

    abstract class Delivery
    {
        public string Address;
    }

    class HomeDelivery : Delivery
    {
        /* ... */
    }

    class PickPointDelivery : Delivery
    {
        /* ... */
    }

    class ShopDelivery : Delivery
    {
        /* ... */
    }

    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public Person OrderPerson(List<Person> person)
        {
            Random random = new Random();   
            return person[random.Next(1, person.Count)];
        }

        
    }
}

