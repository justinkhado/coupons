using Coupons.models.interfaces;

namespace Coupons.models;

public class Coupon : ICoupon
{
    public string Name { get; set; } = string.Empty;
    public float Discount { get; set; }
    public bool IsQuantityDependent { get; set; } = false;
}