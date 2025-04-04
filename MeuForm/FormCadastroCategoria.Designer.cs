namespace MeuForm
{
    partial class FormCadastroCategoria
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
            btnSalvar = new Button();
            btnVoltar = new Button();
            grvCategoria = new DataGridView();
            label1 = new Label();
            txtNomeCategoria = new TextBox();
            txtIdCategoria = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnCancelar = new Button();
            lblMensagem = new Label();
            bntDeletar = new Button();
            ((System.ComponentModel.ISupportInitialize)grvCategoria).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(282, 108);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(102, 32);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(644, 415);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // grvCategoria
            // 
            grvCategoria.AllowUserToAddRows = false;
            grvCategoria.AllowUserToDeleteRows = false;
            grvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvCategoria.Location = new Point(12, 195);
            grvCategoria.MultiSelect = false;
            grvCategoria.Name = "grvCategoria";
            grvCategoria.ReadOnly = true;
            grvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvCategoria.Size = new Size(707, 214);
            grvCategoria.TabIndex = 2;
            grvCategoria.CellClick += grvCategoria_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.Location = new Point(66, 74);
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.Size = new Size(318, 23);
            txtNomeCategoria.TabIndex = 4;
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Enabled = false;
            txtIdCategoria.Location = new Point(66, 45);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(117, 23);
            txtIdCategoria.TabIndex = 6;
            txtIdCategoria.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 5;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(247, 9);
            label3.Name = "label3";
            label3.Size = new Size(230, 28);
            label3.TabIndex = 7;
            label3.Text = "Cadastro de Categorias";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(174, 113);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 22);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(66, 156);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 15);
            lblMensagem.TabIndex = 9;
            // 
            // bntDeletar
            // 
            bntDeletar.BackColor = Color.FromArgb(192, 0, 0);
            bntDeletar.ForeColor = SystemColors.ControlLightLight;
            bntDeletar.Location = new Point(596, 108);
            bntDeletar.Name = "bntDeletar";
            bntDeletar.Size = new Size(123, 32);
            bntDeletar.TabIndex = 10;
            bntDeletar.Text = "Deletar Categoria";
            bntDeletar.UseVisualStyleBackColor = false;
            bntDeletar.Click += bntDeletar_Click;
            // 
            // FormCadastroCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 450);
            Controls.Add(bntDeletar);
            Controls.Add(lblMensagem);
            Controls.Add(btnCancelar);
            Controls.Add(label3);
            Controls.Add(txtIdCategoria);
            Controls.Add(label2);
            Controls.Add(txtNomeCategoria);
            Controls.Add(label1);
            Controls.Add(grvCategoria);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Name = "FormCadastroCategoria";
            Text = "Cadastro de Categorias";
            Load += FormCadastroCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)grvCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Button btnVoltar;
        private DataGridView grvCategoria;
        private Label label1;
        private TextBox txtNomeCategoria;
        private TextBox txtIdCategoria;
        private Label label2;
        private Label label3;
        private Button btnCancelar;
        private Label lblMensagem;
        private Button bntDeletar;
    }
}