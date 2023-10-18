using Domain.Shared;
using System;
using System.Collections.Generic;

namespace Domain.CMS.Writer.Entities;

public sealed class Writer : AggregateRoot<Guid>
{
    private Writer(Guid id, string aliasName, Guid personId) : base(id)
    {
        AliasName = aliasName;
        PersonId = personId;
    }
    

    public Guid PersonId { get; private set; }
    public string AliasName { get; private set; } 

    public static Writer Create(
        Guid id,
        string name,
        Guid personId)
    {
        var writer = new Writer(id, name, personId);
        return writer;
    }

    //public Article WriteNewArticle(
    //    Guid articleId,
    //    string title,
    //    string content,
    //    DateTime publishDate)
    //{
    //    var blog = Article.Create(articleId, title, content, publishDate, this);
    //    _articles.Add(blog);
    //    return blog;
    //}
}
