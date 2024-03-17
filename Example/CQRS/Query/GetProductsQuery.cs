using MediatR;

namespace Example.CQRS.Query;

public class GetProductsQuery : IRequest<GetProductsQueryResponse>
{
    public string? NameFiltered { get; set; }
}