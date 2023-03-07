using System.Collections.Generic;

namespace Coupons.models.interfaces;

public interface ICouponList
{
    List<ICoupon> Coupons { get; set; }

    void AddCoupon(ICoupon coupon);

    void RemoveCoupon(string couponName);
}