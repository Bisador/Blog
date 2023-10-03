using Domain.Primitives;
using System;

namespace Domain.Core.Entities;

public class Person : AggregateRoot
{
    private Person(Guid id, string firstName, string lastName, DateOnly birthDate, string emailAddress) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        EmailAddress = emailAddress;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateOnly BirthDate { get; private set; }
    public string EmailAddress { get; private set; }

    public Person Create(Guid id, string firstName, string lastName, DateOnly birthDate, string emailAddress)
    {
        var person = new Person(id, firstName, lastName, birthDate, emailAddress);
        return person;
    }

}
