using MinhaApiComSQLite.Models;

namespace MinhaApiComSQLite.Repository.Contract
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> GetAllAsyn();
        Task<Categoria?> GetByIdAsync(int id);
        Task<int> UpdateAsync(Categoria categoria);
        Task<int> InsertAsync(Categoria categoria);
        Task<int> RemoveAsync(int Id);
    }
}
