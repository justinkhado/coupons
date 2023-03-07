using System.Collections.Generic;

namespace Coupons.models;

public class Inventory : ItemCollection
{
    public Inventory() : base() {}

    public Inventory(Dictionary<string, (float Price, int Quantity)> items)
    {
        Items = new Dictionary<string, (float Price, int Quantity)>(items);
    }
}