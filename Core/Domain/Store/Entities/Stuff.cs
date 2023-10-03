using Domain.Primitives;
using System;

namespace Domain.Store.Entities;

public sealed class Stuff : AggregateRoot
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
