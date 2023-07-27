using Data.Context;
using Entities.Base;
using Entities.Base.Interfaces;
using Entities.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IBaseAudityEntity
{
    protected readonly AppContextDB Ctx;
    public BaseRepository(AppContextDB dbContext)
    {
        Ctx = dbContext;
    }

    public IQueryable<TEntity> GetAll()
    {
        return Ctx.Set<TEntity>().AsNoTracking();
    }

    public TEntity? GetById(Guid id)
    {
        return  Ctx.Set<TEntity>()
            .AsNoTracking()
            .FirstOrDefault(e => e.Id == id);    
    }

    public void Create(TEntity entity)
    {
         Ctx.Set<TEntity>().Add(entity);
         Ctx.SaveChanges();    
    }

    public void Update(Guid id, TEntity entity)
    {
        Ctx.Set<TEntity>().Update(entity);
        Ctx.SaveChanges();    
    }

    public void Delete(Guid id)
    {
        var entity =  GetById(id);
        if (entity != null) Ctx.Set<TEntity>().Remove(entity);
        Ctx.SaveChanges();
    }
}