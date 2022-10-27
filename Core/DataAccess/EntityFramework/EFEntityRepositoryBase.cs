using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework;

public class EFEntityRepositoryBase<TEntity, TContext>
    where TEntity: class, IEntity, new()
    where TContext: DbContext, new()
{
    
}