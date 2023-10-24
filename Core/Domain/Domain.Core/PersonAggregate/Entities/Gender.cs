using Domain.Shared;

namespace Domain.Core.PersonAggregate.Entities;

public class Gender(int id, string name) : Enumeration<GenderEnum>(id, name)
{ 
}

public enum GenderEnum
{
    Male = 1,
    Female = 2,
}
