namespace MeuForm.DTO

{
    public class RespostaDTO<T>
    {
        public T? Dados { get; set; }
        public bool Erro { get; set; } = false;
        public string Mensagem { get; set; } = string.Empty;
    }
}
