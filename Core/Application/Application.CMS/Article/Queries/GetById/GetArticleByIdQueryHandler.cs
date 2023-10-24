

using Application.Abstraction.Messaging;
using Shared;

namespace Application.CMS.Article.Queries.GetById;

public sealed class GetArticleByIdQueryHandler : IQueryHandler<GetArticleByIdQuery, ArticleResponse>
{
    public async Task<Result<ArticleResponse>> Handle(GetArticleByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
