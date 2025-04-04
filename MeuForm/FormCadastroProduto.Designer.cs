namespace MeuForm
{
    partial class FormCadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVoltar = new Button();
            grvProduto = new DataGridView();
            txtIdProduto = new TextBox();
            txtNomeProduto = new TextBox();
            txtPreco = new TextBox();
            lblIdProduto = new Label();
            ddlCategoria = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnDeletar = new Button();
            lblMensagem = new Label();
            btnProxima = new Button();
            btnAnterior = new Button();
            lblPaginaAtual = new Label();
            ((System.ComponentModel.ISupportInitialize)grvProduto).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(713, 556);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // grvProduto
            // 
            grvProduto.AllowUserToAddRows = false;
            grvProduto.AllowUserToDeleteRows = false;
            grvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvProduto.Location = new Point(20, 262);
            grvProduto.MultiSelect = false;
            grvProduto.Name = "grvProduto";
            grvProduto.ReadOnly = true;
            grvProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvProduto.Size = new Size(768, 220);
            grvProduto.TabIndex = 1;
            grvProduto.CellClick += grvProduto_CellClick;
            // 
            // txtIdProduto
            // 
            txtIdProduto.Enabled = false;
            txtIdProduto.Location = new Point(97, 78);
            txtIdProduto.Name = "txtIdProduto";
            txtIdProduto.Size = new Size(101, 23);
            txtIdProduto.TabIndex = 2;
            txtIdProduto.Text = "0";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(97, 107);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(245, 23);
            txtNomeProduto.TabIndex = 3;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(97, 136);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 4;
            txtPreco.Text = "1";
            // 
            // lblIdProduto
            // 
            lblIdProduto.AutoSize = true;
            lblIdProduto.Location = new Point(20, 81);
            lblIdProduto.Name = "lblIdProduto";
            lblIdProduto.Size = new Size(17, 15);
            lblIdProduto.TabIndex = 6;
            lblIdProduto.Text = "Id";
            // 
            // ddlCategoria
            // 
            ddlCategoria.FormattingEnabled = true;
            ddlCategoria.Location = new Point(97, 165);
            ddlCategoria.Name = "ddlCategoria";
            ddlCategoria.Size = new Size(245, 23);
            ddlCategoria.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 110);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 8;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 139);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 9;
            label2.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 168);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 10;
            label3.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(272, 9);
            label4.Name = "label4";
            label4.Size = new Size(215, 28);
            label4.TabIndex = 11;
            label4.Text = "Cadastro de Produtos";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(227, 194);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 37);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(146, 201);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.FromArgb(192, 0, 0);
            btnDeletar.ForeColor = SystemColors.ControlLightLight;
            btnDeletar.Location = new Point(652, 165);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(136, 26);
            btnDeletar.TabIndex = 14;
            btnDeletar.Text = "Deletar Produto";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(97, 235);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 15);
            lblMensagem.TabIndex = 15;
            // 
            // btnProxima
            // 
            btnProxima.Location = new Point(384, 506);
            btnProxima.Name = "btnProxima";
            btnProxima.Size = new Size(75, 23);
            btnProxima.TabIndex = 16;
            btnProxima.Text = "Próxima";
            btnProxima.UseVisualStyleBackColor = true;
            btnProxima.Click += btnProxima_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(283, 506);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 17;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // lblPaginaAtual
            // 
            lblPaginaAtual.AutoSize = true;
            lblPaginaAtual.Location = new Point(330, 547);
            lblPaginaAtual.Name = "lblPaginaAtual";
            lblPaginaAtual.Size = new Size(86, 15);
            lblPaginaAtual.TabIndex = 18;
            lblPaginaAtual.Text = "Página Atual: 1";
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 605);
            Controls.Add(lblPaginaAtual);
            Controls.Add(btnAnterior);
            Controls.Add(btnProxima);
            Controls.Add(lblMensagem);
            Controls.Add(btnDeletar);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ddlCategoria);
            Controls.Add(lblIdProduto);
            Controls.Add(txtPreco);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtIdProduto);
            Controls.Add(grvProduto);
            Controls.Add(btnVoltar);
            Name = "FormCadastroProduto";
            Text = "Cadastro de Produto";
            Load += FormCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)grvProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private DataGridView grvProduto;
        private TextBox txtIdProduto;
        private TextBox txtNomeProduto;
        private TextBox txtPreco;
        private Label lblIdProduto;
        private ComboBox ddlCategoria;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnDeletar;
        private Label lblMensagem;
        private Button btnProxima;
        private Button btnAnterior;
        private Label lblPaginaAtual;
    }
}