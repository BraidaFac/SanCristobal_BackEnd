using GSC_BackEnd_TP.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GSC_BackEnd_TP.DataAccess
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        protected ThingsContext context;
        internal DbSet<TEntity> dbSet;
    
    public GenericRepository(ThingsContext context)
    {
        this.context = context;
        dbSet = context.Set<TEntity>();
    }
    public TEntity Add(TEntity entity)
    {
        var savedEntity = dbSet.Add(entity);
        return savedEntity.Entity;
    }

    public void Delete(int id)
    {
        dbSet.Remove(GetById(id));
    }

    public List<TEntity> GetAll()
    {
        return dbSet.ToList(); //Implementar
    }

    public TEntity GetById(int id)
    {
        return dbSet.SingleOrDefault(t => t.Id == id);
    }


    public TEntity Update(TEntity entity)
    {
        var changedEntity = dbSet.Update(entity);
        return changedEntity.Entity;
    }
}
}
