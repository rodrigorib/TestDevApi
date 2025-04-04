using MinhaApiComSQLite.DTO;
using MinhaApiComSQLite.Models;
using MinhaApiComSQLite.Repository.Contract;
using MinhaApiComSQLite.Service.Contract;

namespace MinhaApiComSQLite.Service
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<List<CategoriaDTO>> GetAllAsync()
        {
            var categorias = await _categoriaRepository.GetAllAsyn();
            List<CategoriaDTO> listaCategorias = new List<CategoriaDTO>();

            foreach (var item in categorias)
            {
                listaCategorias.Add(new CategoriaDTO()
                {
                    IdCategoria = item.IdCategoria,
                    Nome = item.Nome
                });
            }

            return listaCategorias;
        }

        public async Task<CategoriaDTO> GetByIdAsync(int id)
        {
            var categoria = await _categoriaRepository.GetByIdAsync(id);

            if (categoria == null)
                throw new ArgumentException("Categoria inexistente.");

            CategoriaDTO categoriaDTO = new CategoriaDTO();
            categoriaDTO.IdCategoria = categoria.IdCategoria;
            categoriaDTO.Nome = categoria.Nome;

            return categoriaDTO;
        }

        public async Task InsertAsync(CategoriaDTO categoriaDTO)
        {
            if (string.IsNullOrEmpty(categoriaDTO.Nome) || !char.IsUpper(categoriaDTO.Nome[0]))
                throw new ArgumentException("O nome da categoria deve começar com letra maiúscula.");

            Categoria categoria = new Categoria();
            categoria.Nome = categoriaDTO.Nome;

            await _categoriaRepository.InsertAsync(categoria);
        }

        public async Task UpdateAsync(CategoriaDTO categoriaDTO)
        {
            if (string.IsNullOrEmpty(categoriaDTO.Nome) || !char.IsUpper(categoriaDTO.Nome[0]))
                throw new ArgumentException("O nome da categoria deve começar com letra maiúscula.");

            Categoria? categoria = await _categoriaRepository.GetByIdAsync(categoriaDTO.IdCategoria);

            if (categoria == null)
                throw new ArgumentException("Categoria inexistente.");

            categoria.Nome = categoriaDTO.Nome;

            await _categoriaRepository.UpdateAsync(categoria);
        }

        public async Task DeleteAsync(int id)
        {
            Categoria? categoria = await _categoriaRepository.GetByIdAsync(id);

            if (categoria == null)
                throw new ArgumentException("Categoria inexistente. Não foi possível deletar.");

            await _categoriaRepository.RemoveAsync(id);
        }
    }
}
