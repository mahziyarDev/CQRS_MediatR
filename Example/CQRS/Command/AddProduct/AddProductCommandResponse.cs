namespace Example.CQRS.Command.AddProduct;

public class AddProductCommandResponse
{
    public Guid ProductId { get; set; }
    public string ProductName { get; set; }
}