using MeuForm.DTO;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MeuForm.Service
{
    public class CategoriaService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://localhost:44397/api/categoria";

        public CategoriaService()
        {
            HttpClient httpClient = new HttpClient();
            _httpClient = httpClient;
        }

        public async Task<RespostaDTO<List<CategoriaDTO>>> GetCategoriasAsync()
        {
            //HttpResponseMessage responseMessage = await _httpClient.GetFromJsonAsync<List<Categoria>>($"{_baseUrl}/GetCategorias");

            RespostaDTO<List<CategoriaDTO>> resposta = new RespostaDTO<List<CategoriaDTO>>();
            var httpResponse = await _httpClient.GetAsync($"{_baseUrl}/GetCategorias");

            if (!httpResponse.IsSuccessStatusCode)
            {
                resposta.Erro = true;
                resposta.Mensagem = await httpResponse.Content.ReadAsStringAsync();
            }
            else
            {
                resposta.Dados = await httpResponse.Content.ReadFromJsonAsync<List<CategoriaDTO>>();
            }

            return resposta;
        }

        public async Task<RespostaDTO<bool>> InsertCategoriaAsync(CategoriaDTO categoria)
        {
            RespostaDTO<bool> resposta = new RespostaDTO<bool>();
            var httpResponse = await _httpClient.PostAsJsonAsync($"{_baseUrl}/Insert", categoria);

            if (!httpResponse.IsSuccessStatusCode)
            {
                resposta.Erro = true;
                resposta.Mensagem = httpResponse.Content.ReadAsStringAsync().Result;
            }
            else
            {
                resposta.Mensagem = "Cadastrado com sucesso";
            }

            return resposta;
        }

        public async Task<RespostaDTO<bool>> UpdateCategoriaAsync(CategoriaDTO categoria)
        {
            RespostaDTO<bool> resposta = new RespostaDTO<bool>();

            var httpResponse = await _httpClient.PostAsJsonAsync($"{_baseUrl}/Update", categoria);

            if (!httpResponse.IsSuccessStatusCode)
            {
                resposta.Erro = true;
                resposta.Mensagem = httpResponse.Content.ReadAsStringAsync().Result;
            }
            else
            {
                resposta.Mensagem = "Atualizado com sucesso";
            }

            return resposta;
        }

        public async Task<RespostaDTO<bool>> DeleteCategoriaAsync(int id)
        {
            RespostaDTO<bool> resposta = new RespostaDTO<bool>();

            var httpResponse = await _httpClient.DeleteAsync($"{_baseUrl}/Delete?id={id}");

            if (!httpResponse.IsSuccessStatusCode)
            {
                resposta.Erro = true;
                resposta.Mensagem = httpResponse.Content.ReadAsStringAsync().Result;
            }
            else
            {
                resposta.Mensagem = "Deletado com sucesso";
            }

            return resposta;
        }
    }
}
