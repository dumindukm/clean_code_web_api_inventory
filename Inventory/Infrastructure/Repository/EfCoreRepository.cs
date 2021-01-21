using ApplicationCore.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class EfCoreRepository<T> : IRepository<T> where T : class
    {
        private readonly InventoryDbContext db;
        public EfCoreRepository(InventoryDbContext context)
        {
            db = context;
        }
        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await db.Set<T>().ToListAsync();
        }
    }
}
