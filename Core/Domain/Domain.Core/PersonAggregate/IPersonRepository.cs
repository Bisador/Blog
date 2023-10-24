using Domain.Abstraction;
using Domain.Core.Entities; 

namespace Domain.Core.PersonAggregate;

public interface IPersonRepository : IRepository<Person, Guid>
{
}
