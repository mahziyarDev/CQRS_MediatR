using Example.Domain.Product;
using Example.DTOs;

namespace Example.CQRS.Query;

public class GetProductsQueryResponse
{
    public List<ProductDto> Producs { get; set; }
}