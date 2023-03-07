namespace Coupons.models.interfaces;

public interface IItem
{
    string Name { get; }

    float Price { get; set; }
}