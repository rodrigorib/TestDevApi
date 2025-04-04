namespace MeuForm
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastroCategoria = new Button();
            btnCadastroProdutos = new Button();
            SuspendLayout();
            // 
            // btnCadastroCategoria
            // 
            btnCadastroCategoria.Location = new Point(113, 174);
            btnCadastroCategoria.Name = "btnCadastroCategoria";
            btnCadastroCategoria.Size = new Size(257, 76);
            btnCadastroCategoria.TabIndex = 0;
            btnCadastroCategoria.Text = "Cadastro de Categorias";
            btnCadastroCategoria.UseVisualStyleBackColor = true;
            btnCadastroCategoria.Click += btnCadastroCategoria_Click;
            // 
            // btnCadastroProdutos
            // 
            btnCadastroProdutos.Location = new Point(476, 174);
            btnCadastroProdutos.Name = "btnCadastroProdutos";
            btnCadastroProdutos.Size = new Size(257, 76);
            btnCadastroProdutos.TabIndex = 1;
            btnCadastroProdutos.Text = "Cadastro de Produtos";
            btnCadastroProdutos.UseVisualStyleBackColor = true;
            btnCadastroProdutos.Click += btnCadastroProdutos_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 501);
            Controls.Add(btnCadastroProdutos);
            Controls.Add(btnCadastroCategoria);
            Name = "FormMenu";
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastroCategoria;
        private Button btnCadastroProdutos;
    }
}
