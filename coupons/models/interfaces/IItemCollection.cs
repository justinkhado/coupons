using System.Collections.Generic;

namespace Coupons.models.interfaces;

public interface IItemCollection
{
    Dictionary<string, (float Price, int Quantity)> Items { get; set; }

    void AddItem(IItem item, int quantity);

    void RemoveItem(string itemName, int quantity);
}