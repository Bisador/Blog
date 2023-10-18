

namespace Application.CMS.Article.Commands;

public class CreateCommandHandler : IRequestHandler<CreateArticleCommand, Guid>
{
    public Task<Guid> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine("Yaaaaa ghamare moshtari");
        return Task.FromResult(Guid.NewGuid());
    }
}
