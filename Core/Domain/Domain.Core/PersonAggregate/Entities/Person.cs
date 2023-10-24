using Domain.Core.PersonAggregate.Entities;
using Domain.Shared;

namespace Domain.Core.Entities;

public class Person : AggregateRoot<Guid>
{
    private Person(Guid id,
                   string firstName,
                   string lastName,
                   DateOnly birthDate,
                   Address? address,
                   string? emailAddress) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        Address = address;
        EmailAddress = emailAddress;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateOnly BirthDate { get; private set; }
    public string? EmailAddress { get; private set; }
    public Address? Address { get; private set; }

    public static Person Create(Guid id, string firstName, string lastName, DateOnly birthDate, Address? address, string? emailAddress) =>
        new(id, firstName, lastName, birthDate, address, emailAddress);

}
