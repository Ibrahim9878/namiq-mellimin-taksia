namespace Lesson16WpfDependenctInjection.Models;

public class Product
{
    public string Id { get; set; } = Guid.NewGuid().ToString(); 
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public double Price { get; set; }

    public bool IsEqual(Product other)
    {
        if(Id == other.Id && Name == other.Name && Quantity == other.Quantity && Price == other.Price)
            return true;
        return false;
    }
}
