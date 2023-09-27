using Domain.Entities.Core;
using Domain.Primitives;
using System;

namespace Domain.Entities.Store;

public sealed class Customer : Entity
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
