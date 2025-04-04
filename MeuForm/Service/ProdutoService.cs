using MeuForm.DTO;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MeuForm.Service
{
    public class ProdutoService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://localhost:44397/api/produto";

        public ProdutoService()
        {
            HttpClient httpClient = new HttpClient();
            _httpClient = httpClient;
        }

        public async Task<RespostaDTO<List<ProdutoDTO>>> GetProdutosAsync(int pageNumber, int pageSize)
        {
            RespostaDTO<List<ProdutoDTO>> resposta = new RespostaDTO<List<ProdutoDTO>>();
            var httpResponse = await _httpClient.GetAsync($"{_baseUrl}/GetProdutos?pageNumber={pageNumber}&pageSize={pageSize}");

            if (!httpResponse.IsSuccessStatusCode)
            {
                resposta.Erro = true;
                resposta.Mensagem = await httpResponse.Content.ReadAsStringAsync();
            }
            else
            {
                resposta.Dados = await httpResponse.Content.ReadFromJsonAsync<List<ProdutoDTO>>();
            }

            return resposta;
        }

        public async Task<RespostaDTO<bool>> InsertProdutoAsync(ProdutoDTO produto)
        {
            RespostaDTO<bool> resposta = new RespostaDTO<bool>();
            var httpResponse = await _httpClient.PostAsJsonAsync($"{_baseUrl}/Insert", produto);

            if (!httpResponse.IsSuccessStatusCode)
            {
                resposta.Erro = true;
                resposta.Mensagem = await httpResponse.Content.ReadAsStringAsync();

            }
            else
            {
                resposta.Mensagem = "Cadastrado com sucesso";
            }

            return resposta;
        }

        public async Task<RespostaDTO<bool>> UpdateProdutoAsync(ProdutoDTO produto)
        {
            RespostaDTO<bool> resposta = new RespostaDTO<bool>();

            var httpResponse = await _httpClient.PostAsJsonAsync($"{_baseUrl}/Update", produto);

            if (!httpResponse.IsSuccessStatusCode)
            {
                resposta.Erro = true;
                resposta.Mensagem = await httpResponse.Content.ReadAsStringAsync();
            }
            else
            {
                resposta.Mensagem = "Atualizado com sucesso";
            }

            return resposta;
        }

        public async Task<RespostaDTO<bool>> DeleteProdutoAsync(int id)
        {
            RespostaDTO<bool> resposta = new RespostaDTO<bool>();

            var httpResponse = await _httpClient.DeleteAsync($"{_baseUrl}/Delete?id={id}");

            if (!httpResponse.IsSuccessStatusCode)
            {
                resposta.Erro = true;
                resposta.Mensagem = await httpResponse.Content.ReadAsStringAsync();
            }
            else
            {
                resposta.Mensagem = "Deletado com sucesso";
            }

            return resposta;
        }
    }
}
