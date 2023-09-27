using Domain.Primitives;
using System;

namespace Domain.Entities.Store;

public sealed class Stuff : Entity
{
    private Stuff(Guid id, string name) : base(id)
    {
        Name = name;
    }

    public string Name { get; private set; }

    public Stuff Create(
        Guid id,
        string name)
    {
        var stuff = new Stuff(id, name);
        return stuff;
    }

}
