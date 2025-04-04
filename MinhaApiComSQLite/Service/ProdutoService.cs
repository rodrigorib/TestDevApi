using MinhaApiComSQLite.DTO;
using MinhaApiComSQLite.Models;
using MinhaApiComSQLite.Repository.Contract;
using MinhaApiComSQLite.Service.Contract;

namespace MinhaApiComSQLite.Service
{
    public class ProdutoService: IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<List<ProdutoDTO>> GetAllAsync(int pageNumer = 1, int pageSize = 10)
        {
            var produtos = await _produtoRepository.GetAllAsyn(pageNumer, pageSize);
            List<ProdutoDTO> listaProdutos = new List<ProdutoDTO>();

            foreach (var item in produtos)
            {
                listaProdutos.Add(new ProdutoDTO()
                {
                    IdProduto = item.Id,
                    Nome = item.Nome,
                    Preco = item.Preco,
                    IdCategoria = item.IdCategoria,
                    NomeCategoria = item.Categoria.Nome
                });
            }

            return listaProdutos;
        }

        public async Task<ProdutoDTO> GetByIdAsync(int id)
        {
            var produto = await _produtoRepository.GetByIdAsync(id);

            if (produto == null)
                throw new ArgumentException("Produto inexistente.");

            ProdutoDTO produtoDTO = new ProdutoDTO();
            produtoDTO.IdProduto = produto.Id;
            produtoDTO.Nome = produto.Nome;
            produtoDTO.Preco = produto.Preco;
            produtoDTO.IdCategoria = produto.IdCategoria;
            produtoDTO.NomeCategoria = produto.Categoria.Nome;

            return produtoDTO;
        }

        public async Task InsertAsync(ProdutoDTO produtoDTO)
        {
            if (string.IsNullOrEmpty(produtoDTO.Nome) || !char.IsUpper(produtoDTO.Nome[0]))
                throw new ArgumentException("O nome do produto deve começar com letra maiúscula.");

            if (produtoDTO.Preco <= 0)
                throw new ArgumentException("O preço do produto precisa ser maior que zero.");

            if (produtoDTO.IdCategoria <= 0)
                throw new ArgumentException("Por favor informe uma categoria válida.");

            Produto produto = new Produto();
            produto.Nome = produtoDTO.Nome;
            produto.Preco = produtoDTO.Preco;
            produto.IdCategoria = produtoDTO.IdCategoria;

            await _produtoRepository.InsertAsync(produto);
        }

        public async Task UpdateAsync(ProdutoDTO produtoDTO)
        {
            if (string.IsNullOrEmpty(produtoDTO.Nome) || !char.IsUpper(produtoDTO.Nome[0]))
                throw new ArgumentException("O nome do produto deve começar com letra maiúscula.");

            if (produtoDTO.Preco <= 0)
                throw new ArgumentException("O preço do produto precisa ser maior que zero.");

            Produto? produto = await _produtoRepository.GetByIdAsync(produtoDTO.IdProduto);

            if (produto == null)
                throw new ArgumentException("Produto inexistente.");

            produto.Nome = produtoDTO.Nome;
            produto.Preco = produtoDTO.Preco;
            produto.IdCategoria = produtoDTO.IdCategoria;

            await _produtoRepository.UpdateAsync(produto);
        }

        public async Task DeleteAsync(int id)
        {
            Produto? produto = await _produtoRepository.GetByIdAsync(id);

            if (produto == null)
                throw new ArgumentException("Produto inexistente. Não foi possível deletar.");

            await _produtoRepository.RemoveAsync(id);
        }
    }
}
