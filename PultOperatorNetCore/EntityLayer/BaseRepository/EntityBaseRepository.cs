using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PultOperatorNetCore.EntityLayer.BaseRepository
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContextFactory _contextFactory;
        public EntityBaseRepository(AppDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task AddAsync(T entity)
        {
            using AppDbContext _context = _contextFactory.CreateDbContext();
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            using AppDbContext _context = _contextFactory.CreateDbContext();
            T entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            using AppDbContext _context = _contextFactory.CreateDbContext();
            return await _context.Set<T>().ToListAsync();
        }
        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            using AppDbContext _context = _contextFactory.CreateDbContext();
            IQueryable<T> query = _context.Set<T>();
            query = includeProperties.Aggregate(query, (current, includePropertie) => current.Include(includePropertie));
            return await query.ToListAsync();
        }
        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
            using AppDbContext _context = _contextFactory.CreateDbContext();
            IQueryable<T> query = _context.Set<T>().Where(expression);
            return await query.ToListAsync();


        }

        public async Task<T> GetByIdAsync(int id)
        {
            using AppDbContext _context = _contextFactory.CreateDbContext();
            return await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
        }


        public async Task<T> GetFirstAsync(Expression<Func<T, bool>> expression)
        {
            using AppDbContext _context = _contextFactory.CreateDbContext();
            IQueryable<T> query = _context.Set<T>().Where(expression);
            return await query.FirstOrDefaultAsync();
        }



        public async Task UpdateAsync(int id, T entity)
        {
            using AppDbContext _context = _contextFactory.CreateDbContext();
            entity.Id = id;
            if(entity != null) { 
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            }
        }
    }
}
