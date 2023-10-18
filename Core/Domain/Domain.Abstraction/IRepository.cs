 

namespace Domain.Abstraction;

public interface IRepository<AggregateType, IdType> where AggregateType : IAggregateRoot<IdType>
{
    Task<AggregateType> Get(IdType id);
    Task Add(AggregateType item);
    Task Update(AggregateType item);
    Task Delete(AggregateType item);
}
