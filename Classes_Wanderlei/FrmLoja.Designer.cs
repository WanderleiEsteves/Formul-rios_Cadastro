namespace Classes_Wanderlei
{
    partial class FrmLoja
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
            this.mnsMenuLoja = new System.Windows.Forms.MenuStrip();
            this.mnsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAlimento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrefeito = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua_Av = new System.Windows.Forms.TextBox();
            this.mtxCep = new System.Windows.Forms.MaskedTextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRua_Av = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.mtxCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.mnsMenuLoja.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenuLoja
            // 
            this.mnsMenuLoja.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnsMenuLoja.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsMenu});
            this.mnsMenuLoja.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuLoja.Name = "mnsMenuLoja";
            this.mnsMenuLoja.Size = new System.Drawing.Size(775, 24);
            this.mnsMenuLoja.TabIndex = 1;
            this.mnsMenuLoja.Text = "menuStrip1";
            // 
            // mnsMenu
            // 
            this.mnsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAlimento,
            this.tsmiPrefeito});
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(50, 20);
            this.mnsMenu.Text = "Menu";
            // 
            // tsmiAlimento
            // 
            this.tsmiAlimento.Name = "tsmiAlimento";
            this.tsmiAlimento.Size = new System.Drawing.Size(184, 22);
            this.tsmiAlimento.Text = "Formulário Alimento";
            this.tsmiAlimento.Click += new System.EventHandler(this.tsmiAlimento_Click);
            // 
            // tsmiPrefeito
            // 
            this.tsmiPrefeito.Name = "tsmiPrefeito";
            this.tsmiPrefeito.Size = new System.Drawing.Size(184, 22);
            this.tsmiPrefeito.Text = "Formulário Prefeito";
            this.tsmiPrefeito.Click += new System.EventHandler(this.tsmiPrefeito_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(290, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 33);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Cadastrar Loja";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(320, 127);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(52, 15);
            this.lblCnpj.TabIndex = 5;
            this.lblCnpj.Text = "*CNPJ:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(439, 167);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(48, 20);
            this.txtNumero.TabIndex = 25;
            // 
            // txtRua_Av
            // 
            this.txtRua_Av.Location = new System.Drawing.Point(139, 169);
            this.txtRua_Av.Name = "txtRua_Av";
            this.txtRua_Av.Size = new System.Drawing.Size(208, 20);
            this.txtRua_Av.TabIndex = 24;
            // 
            // mtxCep
            // 
            this.mtxCep.Location = new System.Drawing.Point(572, 127);
            this.mtxCep.Mask = "00000-000";
            this.mtxCep.Name = "mtxCep";
            this.mtxCep.Size = new System.Drawing.Size(76, 20);
            this.mtxCep.TabIndex = 23;
            this.mtxCep.ValidatingType = typeof(System.DateTime);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(362, 168);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(71, 16);
            this.lblNumero.TabIndex = 22;
            this.lblNumero.Text = "*Número:";
            // 
            // lblRua_Av
            // 
            this.lblRua_Av.AutoSize = true;
            this.lblRua_Av.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua_Av.Location = new System.Drawing.Point(26, 170);
            this.lblRua_Av.Name = "lblRua_Av";
            this.lblRua_Av.Size = new System.Drawing.Size(107, 16);
            this.lblRua_Av.TabIndex = 21;
            this.lblRua_Av.Text = "*Rua/Avenida:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(519, 128);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(47, 16);
            this.lblCep.TabIndex = 20;
            this.lblCep.Text = "*CEP:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(308, 213);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(114, 20);
            this.txtCidade.TabIndex = 31;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(89, 212);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(131, 20);
            this.txtBairro.TabIndex = 30;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(615, 168);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(135, 20);
            this.txtComplemento.TabIndex = 29;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(235, 214);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(67, 16);
            this.lblCidade.TabIndex = 28;
            this.lblCidade.Text = "*Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(25, 213);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(59, 16);
            this.lblBairro.TabIndex = 27;
            this.lblBairro.Text = "*Bairro:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(497, 169);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(112, 16);
            this.lblComplemento.TabIndex = 26;
            this.lblComplemento.Text = "*Complemento:";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(488, 214);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(93, 20);
            this.txtPais.TabIndex = 35;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(665, 214);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(85, 20);
            this.txtEstado.TabIndex = 34;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(434, 215);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(48, 16);
            this.lblPais.TabIndex = 33;
            this.lblPais.Text = "*País:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(593, 215);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 16);
            this.lblEstado.TabIndex = 32;
            this.lblEstado.Text = "*Estado:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 125);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(208, 20);
            this.txtNome.TabIndex = 37;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(25, 126);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 16);
            this.lblNome.TabIndex = 36;
            this.lblNome.Text = "*Nome:";
            // 
            // mtxCnpj
            // 
            this.mtxCnpj.Location = new System.Drawing.Point(377, 126);
            this.mtxCnpj.Mask = "00.000.000/0000-00";
            this.mtxCnpj.Name = "mtxCnpj";
            this.mtxCnpj.Size = new System.Drawing.Size(120, 20);
            this.mtxCnpj.TabIndex = 38;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(685, 37);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(65, 13);
            this.lblAviso.TabIndex = 39;
            this.lblAviso.Text = "* Obrigatório";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(394, 269);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(114, 32);
            this.btnLimpar.TabIndex = 41;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(266, 269);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(114, 32);
            this.btnCadastrar.TabIndex = 40;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // FrmLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 329);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.mtxCnpj);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtRua_Av);
            this.Controls.Add(this.mtxCep);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblRua_Av);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mnsMenuLoja);
            this.Name = "FrmLoja";
            this.Text = "Formulário Loja";
            this.mnsMenuLoja.ResumeLayout(false);
            this.mnsMenuLoja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenuLoja;
        private System.Windows.Forms.ToolStripMenuItem mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlimento;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrefeito;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua_Av;
        private System.Windows.Forms.MaskedTextBox mtxCep;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRua_Av;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox mtxCnpj;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}