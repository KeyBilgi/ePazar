using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Core.Entityes;
namespace Core.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        void IEntityRepository<TEntity>.Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<TEntity>.Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        TEntity IEntityRepository<TEntity>.Get(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        List<TEntity> IEntityRepository<TEntity>.GetList(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<TEntity>.Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
