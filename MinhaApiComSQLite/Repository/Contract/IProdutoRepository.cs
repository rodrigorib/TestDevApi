using MinhaApiComSQLite.Models;

namespace MinhaApiComSQLite.Repository.Contract
{
    public interface IProdutoRepository
    {
        Task<List<Produto>> GetAllAsyn(int pageNumber, int pageSize);
        Task<Produto?> GetByIdAsync(int id);
        Task<int> UpdateAsync(Produto produto);
        Task<int> InsertAsync(Produto produto);
        Task<int> RemoveAsync(int Id);
    }
}
