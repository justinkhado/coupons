using System.Collections.Generic;
using Coupons.models.interfaces;

namespace Coupons.models;

public class CouponList
{
    List<ICoupon> Coupons { get; set; }

    public CouponList(List<ICoupon> coupons)
    {
        Coupons = coupons ?? new List<ICoupon>();
    }

    public void AddCoupon(ICoupon coupon)
    {
        Coupons.Add(coupon);
    }

    public void RemoveCoupon(string couponName)
    {
        Coupons.RemoveAll(cpn => cpn.Name == couponName);
    }
}