﻿ 
using Application.Abstraction.Messaging;
using Application.CMS.Article.Commands.Create;
using Shared;

namespace Application.CMS.Article.Commands;

public class CreateCommandHandler : ICommandHandler<CreateArticleCommand>
{
    public Task<Result> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine("Yaaaaa ghamare moshtari");
        return Task.FromResult(Result.Success);
    }
     
}
