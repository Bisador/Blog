

using Shared;

namespace Domain.Abstraction;

public interface IRepository<AggregateType, IdType> where AggregateType : IAggregateRoot<IdType>
{
    Task<Result<AggregateType>> GetAsync(IdType id);
    Task AddAsync(AggregateType item);
    Task UpdateAsync(AggregateType item);
    Task DeleteAsync(AggregateType item);

    IUnitOfWork UnitOfWork { get; }
}
