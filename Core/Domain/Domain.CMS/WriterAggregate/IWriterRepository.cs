
using Domain.Abstraction;
using Domain.CMS.WriterAggregate.Entities;
using System;

namespace Domain.CMS.WriterAggregate;

public interface IWriterRepository : IRepository<Writer, Guid>
{
}
