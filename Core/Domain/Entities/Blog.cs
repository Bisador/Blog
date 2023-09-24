
 
using Domain.Primitives;
using System;

namespace Domain.Entities
{
    public sealed class Blog : Entity
    {
        public Blog(Guid id, string title, string content, DateTime publishDate, Writer writer) : base(id)
        {
            Title = title;
            Content = content;
            PublishDate = publishDate;
            Writer = writer;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public Writer Writer { get; set; }
    }
}
