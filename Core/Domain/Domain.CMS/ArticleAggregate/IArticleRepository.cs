
using Domain.Abstraction;
using Domain.CMS.ArticleAggregate.Entities;
using System;

namespace Domain.CMS.ArticleAggregate;

public interface IArticleRepository : IRepository<Article, Guid>
{
}
