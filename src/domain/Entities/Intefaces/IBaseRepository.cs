using Entities.Base;
using Entities.Base.Interfaces;

namespace Entities.Intefaces;

public interface IBaseRepository<TEntity> 
    where TEntity : class, IBaseAudityEntity
{
    IQueryable<TEntity> GetAll();

    TEntity? GetById(Guid id);

    void Create(TEntity entity);

    void Update(Guid id, TEntity entity);

    void Delete(Guid id);
}