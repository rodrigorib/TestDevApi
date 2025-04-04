using MeuForm.DTO;
using MeuForm.Service;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuForm
{
    public partial class FormCadastroCategoria : Form
    {
        public FormCadastroCategoria()
        {
            InitializeComponent();
        }
        private void FormCadastroCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                CarregaGrvCategoria();
            }
            catch { /*Tratamento de erro*/ }
        }

        private async void CarregaGrvCategoria()
        {
            CategoriaService categoriaService = new CategoriaService();
            var respostaCategoria = await categoriaService.GetCategoriasAsync();

            if (!respostaCategoria.Erro)
                grvCategoria.DataSource = respostaCategoria.Dados;
            else
                lblMensagem.Text = respostaCategoria.Mensagem;
        }

        private void LimparForm()
        {
            txtIdCategoria.Text = "0";
            txtNomeCategoria.Text = string.Empty;
        }

        private async void Salvar()
        {
            CategoriaDTO categoria = new CategoriaDTO();
            CategoriaService categoriaService = new CategoriaService();

            if (txtIdCategoria.Text.Equals("0"))
            {
                //Insert
                categoria.Nome = txtNomeCategoria.Text;

                var resposta = await categoriaService.InsertCategoriaAsync(categoria);

                lblMensagem.Text = resposta.Mensagem;

                if (!resposta.Erro)
                {
                    CarregaGrvCategoria();
                    LimparForm();
                }
            }
            else
            {
                //Update
                categoria.IdCategoria = Convert.ToInt32(txtIdCategoria.Text);
                categoria.Nome = txtNomeCategoria.Text;

                var resposta = await categoriaService.UpdateCategoriaAsync(categoria);

                lblMensagem.Text = resposta.Mensagem;

                if (!resposta.Erro)
                {
                    CarregaGrvCategoria();
                    LimparForm();
                }
            }
        }

        private async void Deletar()
        {
            CategoriaService categoriaService = new CategoriaService();

            if (!txtIdCategoria.Text.Equals("0"))
            {
                var resposta = await categoriaService.DeleteCategoriaAsync(Convert.ToInt32(txtIdCategoria.Text));

                lblMensagem.Text = resposta.Mensagem;

                if (!resposta.Erro)
                {
                    CarregaGrvCategoria();
                    LimparForm();
                }
            }
            else
            {
                lblMensagem.Text = "Selecione uma Categoria para Deletar";
            }
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

        private void grvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdCategoria.Text = grvCategoria.Rows[e.RowIndex].Cells["IdCategoria"].Value.ToString();
                txtNomeCategoria.Text = grvCategoria.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            }
            catch { /*Tratamento de erro*/ }
        }

        private void bntDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                Deletar();
                LimparForm();
            }
            catch { /*Tratamento de erro*/ }
        }
    }
}
