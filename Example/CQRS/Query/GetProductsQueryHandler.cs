using Example.Base;
using Example.DTOs;
using MediatR;


namespace Example.CQRS.Query;

public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery,GetProductsQueryResponse>
{
    private readonly Context _context;

    public GetProductsQueryHandler(Context context)
    {
        _context = context;
    }

    public async Task<GetProductsQueryResponse> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        var result = Context.GetProducts(request.NameFiltered);
        return new GetProductsQueryResponse()
        {
            Producs = result.Select(x => new ProductDto()
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList()
        };
    }
}
