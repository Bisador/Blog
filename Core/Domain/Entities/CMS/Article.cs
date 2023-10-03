using Domain.Primitives;
using System;

namespace Domain.Entities.CMS
{
    public sealed class Article : AggregateRoot
    {
        private Article(
            Guid id,
            string title,
            string content,
            DateTime publishDate,
            Writer writer) : base(id)
        {
            Title = title;
            Content = content;
            PublishDate = publishDate;
            Writer = writer;
        }

        public string Title { get; private set; }
        public string Content { get; private set; }
        public DateTime PublishDate { get; private set; }
        public Writer Writer { get; private set; }

        internal static Article Create(
            Guid id,
            string title,
            string content,
            DateTime publishDate,
            Writer writer)
        {
            var blog = new Article(id, title, content, publishDate, writer);
            return blog;
        }
    }
}
