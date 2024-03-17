﻿using MediatR;

namespace Example.CQRS.Command.AddProduct;

public class AddProductCommand : IRequest<AddProductCommandResponse>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long Price { get; set; }
}