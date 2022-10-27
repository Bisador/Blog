using Domain.Common;

namespace Domain.Entities
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Writer Writer { get; set; }
    }
}
