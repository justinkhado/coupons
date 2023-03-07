using System.Collections.Generic;
using Coupons.models;
using Coupons.models.interfaces;

namespace Coupons.controllers;

public class CouponsController
{
    public Inventory Inventory { get; }
    public Cart Cart { get; }
    public CouponList Coupons { get; }

    public CouponsController(Dictionary<string, (float Price, int Quantity)> inventory, List<ICoupon> coupons)
    {
        Inventory = new Inventory(inventory);
        Cart = new Cart();
        Coupons = new CouponList(coupons);
    }

    public void AddToCart(Item item, int quantity = 1)
    {
        Inventory.RemoveItem(item.Name, quantity);
        Cart.AddItem(item, quantity);
    }
}