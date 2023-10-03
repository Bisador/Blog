using Domain.Core.Entities;
using Domain.Primitives;
using System;

namespace Domain.Store.Entities;

public sealed class Customer : AggregateRoot
{
    private Customer(Guid id, Person person) : base(id)
    {
        Person = person;
    }

    public Person Person { get; private set; }

    public Customer Create(
        Guid id,
        Person person)
    {
        var customer = new Customer(id, person);
        return customer;
    }

}
