using Example.Base;

namespace Example.Domain.Product;

public class Product : EntityBase<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long Pride { get; set; }
    
}