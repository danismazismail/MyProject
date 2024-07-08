﻿using Core.Entities.Abstract;
using DataAccess.Context;
using DataAccess.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _table;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _table.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = Status.Modified;
            _table.Update(entity);
            await _table.AddRangeAsync(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = Status.Passive;
            _table.Update(entity);
            await _context.SaveChangesAsync();

        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
            => await _table.AnyAsync(expression);

        public async Task<T> GetByDefaultAsync(Expression<Func<T, bool>> expression)
            => await _table.FirstOrDefaultAsync(expression);

        public async Task<List<T>> GetByDefaultListAsync(Expression<Func<T, bool>> expression)
            => await _table.Where(expression).ToListAsync();

        public async Task<T> GetByIdAsync(int Id)
            => await _table.FirstOrDefaultAsync(x => x.Status != Status.Passive && x.Id == Id);

        public async Task<List<TResault>> GetFiltredListAsync<TResault>(Expression<Func<T, TResault>> select, Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null)
        {
            IQueryable<T> query = _table;

            if (join != null)
                query = join(query);
            if (where != null)
                query = query.Where(where);
            if (orderBy != null)
                return await orderBy(query).Select(select).ToListAsync();
            else
                return await query.Select(select).ToListAsync();
        }
    }
}