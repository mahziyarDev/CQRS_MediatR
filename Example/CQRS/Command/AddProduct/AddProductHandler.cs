using Example.Base;
using Example.Domain.Product;
using MediatR;

namespace Example.CQRS.Command.AddProduct;

public class AddProductHandler : IRequestHandler<AddProductCommand,AddProductCommandResponse>
{
    private readonly Context _context;

    public AddProductHandler(Context context)
    {
        _context = context;
    }
    
    public async Task<AddProductCommandResponse> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product()
        {
            Description = request.Description,
            Id = Guid.NewGuid(),
            Name = request.Name,
            Pride = request.Price,
            CreateDate = DateTime.Now,
        };
        
        var result = _context.AddProduct(product);
        if (result)
        {
            return new AddProductCommandResponse { ProductId = product.Id, ProductName = product.Name };            
        }

        throw new Exception("محصول ثبت نشد");
    }
}