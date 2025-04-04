using MeuForm.DTO;
using MeuForm.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuForm
{
    public partial class FormCadastroProduto : Form
    {
        private int _paginaAtual = 1;
        private int _tamanhoPaginacao = 5;

        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            try
            {
                CarregaDdlCategoria();
                CarregaGrvProduto();
            }
            catch { /*Tratamento de erro*/ }
        }

        private async void CarregaGrvProduto()
        {
            ProdutoService produtoService = new ProdutoService();
            var respostaProduto = await produtoService.GetProdutosAsync(_paginaAtual, _tamanhoPaginacao);

            if (!respostaProduto.Erro)
                grvProduto.DataSource = respostaProduto.Dados;
            else
                lblMensagem.Text = respostaProduto.Mensagem;
        }

        private async void CarregaDdlCategoria()
        {
            CategoriaService categoriaService = new CategoriaService();
            var respostaCategoria = await categoriaService.GetCategoriasAsync();

            if (!respostaCategoria.Erro)
            {
                ddlCategoria.DataSource = respostaCategoria.Dados;
                ddlCategoria.DisplayMember = "Nome";
                ddlCategoria.ValueMember = "IdCategoria";
            }
            else
                lblMensagem.Text = respostaCategoria.Mensagem;
        }

        private void MovePaginacao(int add)
        {
            if (_paginaAtual + add <= 0)
            {
                _paginaAtual = 1;
            }
            else
            {
                _paginaAtual = _paginaAtual + add;
            }

            lblPaginaAtual.Text = $"Página Atual: {_paginaAtual}";
        }

        private void LimparForm()
        {
            txtIdProduto.Text = "0";
            txtNomeProduto.Text = string.Empty;
            txtPreco.Text = "1";

            if (ddlCategoria.Items.Count > 0)
                ddlCategoria.SelectedIndex = 0;
        }

        private async void Salvar()
        {
            ProdutoDTO produto = new ProdutoDTO();
            ProdutoService produtoService = new ProdutoService();

            if (txtIdProduto.Text.Equals("0"))
            {
                //Insert
                produto.Nome = txtNomeProduto.Text;
                produto.Preco = Convert.ToDecimal(txtPreco.Text);
                produto.IdCategoria = Convert.ToInt32(ddlCategoria.SelectedValue);
                produto.NomeCategoria = ddlCategoria.SelectedText;

                var resposta = await produtoService.InsertProdutoAsync(produto);

                lblMensagem.Text = resposta.Mensagem;

                if (!resposta.Erro)
                {
                    CarregaGrvProduto();
                    LimparForm();
                }
            }
            else
            {
                //Update
                produto.IdProduto = Convert.ToInt32(txtIdProduto.Text);
                produto.Nome = txtNomeProduto.Text;
                produto.Preco = Convert.ToDecimal(txtPreco.Text);
                produto.IdCategoria = Convert.ToInt32(ddlCategoria.SelectedValue);
                produto.NomeCategoria = ddlCategoria.SelectedText;

                var resposta = await produtoService.UpdateProdutoAsync(produto);

                lblMensagem.Text = resposta.Mensagem;

                if (!resposta.Erro)
                {
                    CarregaGrvProduto();
                    LimparForm();
                }
            }
        }

        private async void Deletar()
        {
            ProdutoService produtoService = new ProdutoService();

            if (!txtIdProduto.Text.Equals("0"))
            {
                var resposta = await produtoService.DeleteProdutoAsync(Convert.ToInt32(txtIdProduto.Text));

                lblMensagem.Text = resposta.Mensagem;

                if (!resposta.Erro)
                {
                    CarregaGrvProduto();
                    LimparForm();
                }
            }
            else
            {
                lblMensagem.Text = "Selecione uma Produto para Deletar";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Salvar();
            }
            catch { /*Tratamento de erro*/ }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparForm();
                lblMensagem.Text = string.Empty;
            }
            catch { /*Tratamento de erro*/ }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                this.Hide();
            }
            catch { /*Tratamento de erro*/ }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                Deletar();
            }
            catch { /*Tratamento de erro*/ }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            MovePaginacao(-1);
            CarregaGrvProduto();
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            MovePaginacao(+1);
            CarregaGrvProduto();
        }

        private void grvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdProduto.Text = grvProduto.Rows[e.RowIndex].Cells["IdProduto"].Value.ToString();
                txtNomeProduto.Text = grvProduto.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                txtPreco.Text = grvProduto.Rows[e.RowIndex].Cells["Preco"].Value.ToString();
                ddlCategoria.SelectedValue = Convert.ToInt32(grvProduto.Rows[e.RowIndex].Cells["IdCategoria"].Value);
            }
            catch { /*Tratamento de erro*/ }
        }
    }
}
