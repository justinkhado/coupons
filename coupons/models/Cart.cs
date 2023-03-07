public class Cart : ItemCollection
{
    public float Total { get; set; }

    public Cart() : base()
    {
        Total = 0;
    }

    public new void AddItem(IItem item, int quantity = 1)
    {
        base.AddItem(item, quantity);

        Total += item.Price * quantity;
    }

    public new void RemoveItem(string item, int quantity = 1)
    {
        float itemPrice = Items[item].Price;

        base.RemoveItem(item, quantity);

        Total -= itemPrice * quantity;
    }
}