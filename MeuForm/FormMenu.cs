namespace MeuForm
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCadastroCategoria_Click(object sender, EventArgs e)
        {
            FormCadastroCategoria formCategoria = new FormCadastroCategoria();
            formCategoria.Show();
            this.Hide();
        }

        private void btnCadastroProdutos_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formProduto = new FormCadastroProduto();
            formProduto.Show();
            this.Hide();
        }
    }
}
