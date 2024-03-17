using Example.CQRS.Command.AddProduct;
using Example.CQRS.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controller;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Add(AddProductCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpGet("/getproducts")]
    public async Task<IActionResult> Get([FromQuery]GetProductsQuery query)
    {
        return Ok(await _mediator.Send(query));
    }
}