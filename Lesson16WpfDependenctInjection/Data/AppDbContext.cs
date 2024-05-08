using Lesson16WpfDependenctInjection.Models;
using System.Collections.ObjectModel;

namespace Lesson16WpfDependenctInjection.Data;

public class AppDbContext
{
    public ObservableCollection<Product> Products { get; set; } = [];

    public void AddProduct(Product product) => Products.Add(product);
    public void RemoveProduct(Product product) => Products.Remove(product);
    public void RemoveProduct(string id)
    {
        var product = Products.FirstOrDefault(x => x.Id == id);
        if(product is not null)
            Products.Remove(product);
    }

}
