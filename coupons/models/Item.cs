public class Item : IItem
{
    public string Name { get; private set; }
    public float Price { get; set; }

    public Item(string name, float price)
    {
        Name = name;
        Price = price;
    }
}