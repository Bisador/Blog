using Domain.Core.Entities;
using Domain.Primitives;
using System;
using System.Collections.Generic;

namespace Domain.CMS.Entities
{
    public sealed class Writer : AggregateRoot
    {
        private Writer(Guid id, string name, Person person) : base(id)
        {
            Name = name;
            Person = person;
        }
        private readonly List<Article> _articles = new();

        public Person Person { get; private set; }
        public string Name { get; private set; }

        public IReadOnlyCollection<Article> Articles => _articles;

        public static Writer Create(
            Guid id,
            string name,
            Person person)
        {
            var writer = new Writer(id, name, person);
            return writer;
        }

        public Article WriteNewArticle(
            Guid articleId,
            string title,
            string content,
            DateTime publishDate)
        {
            var blog = Article.Create(articleId, title, content, publishDate, this);
            _articles.Add(blog);
            return blog;
        }
    }
}
