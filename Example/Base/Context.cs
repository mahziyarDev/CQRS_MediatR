using Example.Domain.Product;

namespace Example.Base;

public class Context
{ 
    private static List<Product> Products { get; set; } = new();
    static Context()
    {
        Products.Add(
            new Product
            {
                Description = "this is a best Product" ,
                Id = Guid.NewGuid(),
                Name = "Pasta" ,
                Pride = 1200,
                CreateDate = DateTime.Now
            });
    }
    public bool AddProduct(Product product)
    {
        try
        {
            Products.Add(product);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
        
        
    }

    public static IEnumerable<Product> GetProducts( string filter)
    {
        var product = !string.IsNullOrWhiteSpace(filter) ?
            Products.Where(x => x.Name.Contains(filter)).ToList() :
            Products.ToList();
        return product;
    }
    // public 
    
    
}