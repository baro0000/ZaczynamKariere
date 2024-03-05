
using BookAppDataAccess;
using Microsoft.EntityFrameworkCore;
using Warehouse.DataAccess.Entities;

namespace Warehouse.DataAccess
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        protected readonly WarehouseAppContext context;
        private DbSet<T> entities;

        public Repository(WarehouseAppContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetByID(int id)
        {
            return entities.SingleOrDefault(e => e.Id == id);
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = entities.SingleOrDefault(e => e.Id == id);
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
