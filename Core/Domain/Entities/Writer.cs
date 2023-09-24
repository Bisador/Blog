
 
using Domain.Primitives;
using System;

namespace Domain.Entities
{
    public class Writer : Entity
    {
        public Writer(Guid id, string name, string description) : base(id)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
