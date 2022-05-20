namespace Classes_Wanderlei
{
    partial class FrmAlimento
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
            this.mnsMenuAlimento = new System.Windows.Forms.MenuStrip();
            this.tsmiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoja = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrefeito = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblingredientes = new System.Windows.Forms.Label();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.lblCalorias = new System.Windows.Forms.Label();
            this.txtCalorias = new System.Windows.Forms.TextBox();
            this.txtValor_Desc = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblValor_Desc = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.mnsMenuAlimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenuAlimento
            // 
            this.mnsMenuAlimento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnsMenuAlimento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenu});
            this.mnsMenuAlimento.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuAlimento.Name = "mnsMenuAlimento";
            this.mnsMenuAlimento.Size = new System.Drawing.Size(760, 24);
            this.mnsMenuAlimento.TabIndex = 0;
            this.mnsMenuAlimento.Text = "menuStrip1";
            // 
            // tsmiMenu
            // 
            this.tsmiMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoja,
            this.tsmiPrefeito});
            this.tsmiMenu.Name = "tsmiMenu";
            this.tsmiMenu.Size = new System.Drawing.Size(50, 20);
            this.tsmiMenu.Text = "Menu";
            // 
            // tsmiLoja
            // 
            this.tsmiLoja.Name = "tsmiLoja";
            this.tsmiLoja.Size = new System.Drawing.Size(180, 22);
            this.tsmiLoja.Text = "Formulário Loja";
            this.tsmiLoja.Click += new System.EventHandler(this.tsmiLoja_Click);
            // 
            // tsmiPrefeito
            // 
            this.tsmiPrefeito.Name = "tsmiPrefeito";
            this.tsmiPrefeito.Size = new System.Drawing.Size(180, 22);
            this.tsmiPrefeito.Text = "Formulário Prefeito";
            this.tsmiPrefeito.Click += new System.EventHandler(this.tsmiPrefeito_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(663, 38);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(65, 13);
            this.lblAviso.TabIndex = 29;
            this.lblAviso.Text = "* Obrigatório";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(259, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(283, 33);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Cadastrar Alimento";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(96, 123);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(129, 20);
            this.txtNome.TabIndex = 39;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(32, 124);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 16);
            this.lblNome.TabIndex = 38;
            this.lblNome.Text = "*Nome:";
            // 
            // lblingredientes
            // 
            this.lblingredientes.AutoSize = true;
            this.lblingredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingredientes.Location = new System.Drawing.Point(234, 124);
            this.lblingredientes.Name = "lblingredientes";
            this.lblingredientes.Size = new System.Drawing.Size(103, 16);
            this.lblingredientes.TabIndex = 40;
            this.lblingredientes.Text = "*Ingredientes:";
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Location = new System.Drawing.Point(343, 123);
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(208, 20);
            this.txtIngredientes.TabIndex = 41;
            // 
            // lblCalorias
            // 
            this.lblCalorias.AutoSize = true;
            this.lblCalorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalorias.Location = new System.Drawing.Point(563, 124);
            this.lblCalorias.Name = "lblCalorias";
            this.lblCalorias.Size = new System.Drawing.Size(75, 16);
            this.lblCalorias.TabIndex = 42;
            this.lblCalorias.Text = "*Calorias:";
            // 
            // txtCalorias
            // 
            this.txtCalorias.Location = new System.Drawing.Point(644, 123);
            this.txtCalorias.Name = "txtCalorias";
            this.txtCalorias.Size = new System.Drawing.Size(84, 20);
            this.txtCalorias.TabIndex = 43;
            // 
            // txtValor_Desc
            // 
            this.txtValor_Desc.Location = new System.Drawing.Point(482, 161);
            this.txtValor_Desc.Name = "txtValor_Desc";
            this.txtValor_Desc.Size = new System.Drawing.Size(110, 20);
            this.txtValor_Desc.TabIndex = 44;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(175, 160);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(97, 20);
            this.txtValorCompra.TabIndex = 45;
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.Location = new System.Drawing.Point(37, 161);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(132, 16);
            this.lblValorCompra.TabIndex = 46;
            this.lblValorCompra.Text = "*Valor de compra:";
            // 
            // lblValor_Desc
            // 
            this.lblValor_Desc.AutoSize = true;
            this.lblValor_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor_Desc.Location = new System.Drawing.Point(288, 161);
            this.lblValor_Desc.Name = "lblValor_Desc";
            this.lblValor_Desc.Size = new System.Drawing.Size(188, 16);
            this.lblValor_Desc.TabIndex = 47;
            this.lblValor_Desc.Text = "*Valor com 10% desconto:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(387, 209);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(114, 32);
            this.btnLimpar.TabIndex = 49;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(259, 209);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(114, 32);
            this.btnCadastrar.TabIndex = 48;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // FrmAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 277);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblValor_Desc);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.txtValor_Desc);
            this.Controls.Add(this.txtCalorias);
            this.Controls.Add(this.lblCalorias);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.lblingredientes);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mnsMenuAlimento);
            this.MainMenuStrip = this.mnsMenuAlimento;
            this.Name = "FrmAlimento";
            this.Text = "Formulário Alimento";
            this.mnsMenuAlimento.ResumeLayout(false);
            this.mnsMenuAlimento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenuAlimento;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoja;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrefeito;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblingredientes;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.Label lblCalorias;
        private System.Windows.Forms.TextBox txtCalorias;
        private System.Windows.Forms.TextBox txtValor_Desc;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblValor_Desc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}