using MinhaApiComSQLite.DTO;

namespace MinhaApiComSQLite.Service.Contract
{
    public interface IProdutoService
    {
        Task DeleteAsync(int id);
        Task<List<ProdutoDTO>> GetAllAsync(int pageNumber, int pageSize);
        Task<ProdutoDTO> GetByIdAsync(int id);
        Task InsertAsync(ProdutoDTO categoriaDTO);
        Task UpdateAsync(ProdutoDTO categoriaDTO);
    }
}
