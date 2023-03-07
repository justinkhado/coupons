using System.Collections.Generic;
using Coupons.models.interfaces;

namespace Coupons.models;

public class ItemCollection : IItemCollection
{
    public Dictionary<string, (float Price, int Quantity)> Items { get; set; }

    public ItemCollection()
    {
        Items = new Dictionary<string, (float Price, int Quantity)>();
    }

    public void AddItem(IItem item, int quantity = 1)
    {
        if (Items.ContainsKey(item.Name))
        {
            Items[item.Name] = (item.Price, Items[item.Name].Quantity + quantity);
        }
        else
        {
            Items[item.Name] = (item.Price, quantity);
        }
    }

    public void RemoveItem(string item, int quantity = 1)
    {
        if (!Items.ContainsKey(item) || Items[item].Quantity - quantity < 0)
        {
            throw new Exception("Can't decrease quantity by more than current quantity.");
        }
        
        Items[item] = (Items[item].Price, Items[item].Quantity - quantity);
    }
}