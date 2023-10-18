namespace Domain.Abstraction;

public interface IEntity<TKey>
{
    TKey Id { get; }  
}