public interface ICoupon
{
    string Name { get; set; }

    float Discount { get; set; }

    bool IsQuantityDependent { get; set; }
}