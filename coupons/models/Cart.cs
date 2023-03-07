using Coupons.models.interfaces;

namespace Coupons.models;

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

    public new void RemoveItem(string itemName, int quantity = 1)
    {
        float itemPrice = Items[itemName].Price;

        base.RemoveItem(itemName, quantity);

        Total -= itemPrice * quantity;
    }
}