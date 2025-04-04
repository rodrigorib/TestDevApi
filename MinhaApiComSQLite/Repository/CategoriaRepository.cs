using MinhaApiComSQLite.Data;
using MinhaApiComSQLite.Models;
using MinhaApiComSQLite.Repository.Contract;
using System;
using Microsoft.EntityFrameworkCore;

namespace MinhaApiComSQLite.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoriaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Categoria>> GetAllAsyn()
        {
            return await _appDbContext.Categorias.ToListAsync();
        }

        public async Task<Categoria?> GetByIdAsync(int id)
        {
            return await _appDbContext.Categorias.FirstOrDefaultAsync(p => p.IdCategoria == id);
        }

        public async Task<int> InsertAsync(Categoria categoria)
        {
            _appDbContext.Categorias.Add(categoria);
            int rows = await _appDbContext.SaveChangesAsync();

            return rows;
        }

        public async Task<int> RemoveAsync(int Id)
        {
            var categoriaDeletar = await _appDbContext.Categorias.FirstOrDefaultAsync(p => p.IdCategoria == Id);
            _appDbContext.Remove(categoriaDeletar);
            int rows = await _appDbContext.SaveChangesAsync();

            return rows;
        }

        public async Task<int> UpdateAsync(Categoria categoria)
        {
            _appDbContext.Categorias.Update(categoria);
            int rows = await _appDbContext.SaveChangesAsync();

            return rows;
        }
    }
}
