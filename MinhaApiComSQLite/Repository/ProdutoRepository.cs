using MinhaApiComSQLite.Data;
using MinhaApiComSQLite.Models;
using MinhaApiComSQLite.Repository.Contract;
using Microsoft.EntityFrameworkCore;

namespace MinhaApiComSQLite.Repository
{
    public class ProdutoRepository:IProdutoRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProdutoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Produto>> GetAllAsyn(int pageNumber = 1, int pageSize = 10)
        {
            return await _appDbContext.Produtos
                                        .Include(c => c.Categoria)
                                                .OrderBy(p => p.Nome)
                                                .Skip((pageNumber - 1) * pageSize)
                                                .Take(pageSize)
                                                .ToListAsync();
        }

        public async Task<Produto?> GetByIdAsync(int id)
        {
            return await _appDbContext.Produtos
                                        .Include(c => c.Categoria)
                                        .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<int> InsertAsync(Produto produto)
        {
            _appDbContext.Produtos.Add(produto);
            int rows = await _appDbContext.SaveChangesAsync();

            return rows;
        }

        public async Task<int> RemoveAsync(int Id)
        {
            var produtoDeletar = await _appDbContext.Produtos.FirstOrDefaultAsync(p => p.Id == Id);
            _appDbContext.Remove(produtoDeletar);
            int rows = await _appDbContext.SaveChangesAsync();

            return rows;
        }

        public async Task<int> UpdateAsync(Produto produto)
        {
            _appDbContext.Produtos.Update(produto);
            int rows = await _appDbContext.SaveChangesAsync();

            return rows;
        }
    }
}
