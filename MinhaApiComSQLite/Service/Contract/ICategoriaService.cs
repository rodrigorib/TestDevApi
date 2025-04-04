using MinhaApiComSQLite.DTO;

namespace MinhaApiComSQLite.Service.Contract
{
    public interface ICategoriaService
    {
        Task DeleteAsync(int id);
        Task<List<CategoriaDTO>> GetAllAsync();
        Task<CategoriaDTO> GetByIdAsync(int id);
        Task InsertAsync(CategoriaDTO categoriaDTO);
        Task UpdateAsync(CategoriaDTO categoriaDTO);
    }
}