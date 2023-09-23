
using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
