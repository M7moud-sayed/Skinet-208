namespace Core.Entities;

public class ShoppingCart
{
    private object? value; 

    public ShoppingCart()
    {
    }

    public ShoppingCart(object value)
    {
        this.value = value;
    }

    public required string Id { get; set; }
    public List<CartItem> Items { get; set; } = [];
}
