namespace Classes_Wanderlei
{
    partial class FrmPrefeito
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.mtxCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblDt_Nasc = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblRua_Av = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtxDt_Nasc = new System.Windows.Forms.MaskedTextBox();
            this.mtxCep = new System.Windows.Forms.MaskedTextBox();
            this.txtRua_Av = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.tsmiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoja = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAlimento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenuPrefeito = new System.Windows.Forms.MenuStrip();
            this.mnsMenuPrefeito.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(236, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(269, 33);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Cadastrar Prefeito";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(32, 122);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "*Nome:";
            // 
            // mtxCpf
            // 
            this.mtxCpf.Location = new System.Drawing.Point(362, 121);
            this.mtxCpf.Mask = "000.000.000-00";
            this.mtxCpf.Name = "mtxCpf";
            this.mtxCpf.Size = new System.Drawing.Size(93, 20);
            this.mtxCpf.TabIndex = 4;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(310, 122);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(46, 16);
            this.lblCpf.TabIndex = 5;
            this.lblCpf.Text = "*CPF:";
            // 
            // lblDt_Nasc
            // 
            this.lblDt_Nasc.AutoSize = true;
            this.lblDt_Nasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDt_Nasc.Location = new System.Drawing.Point(466, 122);
            this.lblDt_Nasc.Name = "lblDt_Nasc";
            this.lblDt_Nasc.Size = new System.Drawing.Size(158, 16);
            this.lblDt_Nasc.TabIndex = 6;
            this.lblDt_Nasc.Text = "*Data de Nascimento:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(32, 163);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(47, 16);
            this.lblCep.TabIndex = 7;
            this.lblCep.Text = "*CEP:";
            // 
            // lblRua_Av
            // 
            this.lblRua_Av.AutoSize = true;
            this.lblRua_Av.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua_Av.Location = new System.Drawing.Point(172, 163);
            this.lblRua_Av.Name = "lblRua_Av";
            this.lblRua_Av.Size = new System.Drawing.Size(107, 16);
            this.lblRua_Av.TabIndex = 8;
            this.lblRua_Av.Text = "*Rua/Avenida:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(502, 163);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(71, 16);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "*Número:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(32, 201);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(112, 16);
            this.lblComplemento.TabIndex = 10;
            this.lblComplemento.Text = "*Complemento:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(320, 202);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(59, 16);
            this.lblBairro.TabIndex = 11;
            this.lblBairro.Text = "*Bairro:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(519, 203);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(67, 16);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "*Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(34, 242);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 16);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "*Estado:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(239, 242);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(48, 16);
            this.lblPais.TabIndex = 14;
            this.lblPais.Text = "*País:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(96, 121);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(208, 20);
            this.txtNome.TabIndex = 15;
            // 
            // mtxDt_Nasc
            // 
            this.mtxDt_Nasc.Location = new System.Drawing.Point(630, 121);
            this.mtxDt_Nasc.Mask = "00/00/0000";
            this.mtxDt_Nasc.Name = "mtxDt_Nasc";
            this.mtxDt_Nasc.Size = new System.Drawing.Size(76, 20);
            this.mtxDt_Nasc.TabIndex = 16;
            this.mtxDt_Nasc.ValidatingType = typeof(System.DateTime);
            // 
            // mtxCep
            // 
            this.mtxCep.Location = new System.Drawing.Point(85, 162);
            this.mtxCep.Mask = "00000-000";
            this.mtxCep.Name = "mtxCep";
            this.mtxCep.Size = new System.Drawing.Size(76, 20);
            this.mtxCep.TabIndex = 17;
            this.mtxCep.ValidatingType = typeof(System.DateTime);
            // 
            // txtRua_Av
            // 
            this.txtRua_Av.Location = new System.Drawing.Point(285, 162);
            this.txtRua_Av.Name = "txtRua_Av";
            this.txtRua_Av.Size = new System.Drawing.Size(208, 20);
            this.txtRua_Av.TabIndex = 18;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(579, 162);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(127, 20);
            this.txtNumero.TabIndex = 19;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(150, 200);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(164, 20);
            this.txtComplemento.TabIndex = 20;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(384, 201);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(131, 20);
            this.txtBairro.TabIndex = 21;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(592, 202);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(114, 20);
            this.txtCidade.TabIndex = 22;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(106, 241);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(120, 20);
            this.txtEstado.TabIndex = 23;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(293, 241);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(93, 20);
            this.txtPais.TabIndex = 24;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(242, 298);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(114, 32);
            this.btnCadastrar.TabIndex = 25;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(370, 298);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(114, 32);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(641, 33);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(65, 13);
            this.lblAviso.TabIndex = 27;
            this.lblAviso.Text = "* Obrigatório";
            // 
            // tsmiMenu
            // 
            this.tsmiMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoja,
            this.tsmiAlimento});
            this.tsmiMenu.Name = "tsmiMenu";
            this.tsmiMenu.Size = new System.Drawing.Size(50, 20);
            this.tsmiMenu.Text = "Menu";
            // 
            // tsmiLoja
            // 
            this.tsmiLoja.Name = "tsmiLoja";
            this.tsmiLoja.Size = new System.Drawing.Size(184, 22);
            this.tsmiLoja.Text = "Formulário Loja";
            this.tsmiLoja.Click += new System.EventHandler(this.tsmiLoja_Click);
            // 
            // tsmiAlimento
            // 
            this.tsmiAlimento.Name = "tsmiAlimento";
            this.tsmiAlimento.Size = new System.Drawing.Size(184, 22);
            this.tsmiAlimento.Text = "Formulário Alimento";
            this.tsmiAlimento.Click += new System.EventHandler(this.tsmiAlimento_Click);
            // 
            // mnsMenuPrefeito
            // 
            this.mnsMenuPrefeito.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnsMenuPrefeito.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenu});
            this.mnsMenuPrefeito.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuPrefeito.Name = "mnsMenuPrefeito";
            this.mnsMenuPrefeito.Size = new System.Drawing.Size(726, 24);
            this.mnsMenuPrefeito.TabIndex = 1;
            this.mnsMenuPrefeito.Text = "menuStrip1";
            // 
            // FrmPrefeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 352);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtRua_Av);
            this.Controls.Add(this.mtxCep);
            this.Controls.Add(this.mtxDt_Nasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblRua_Av);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblDt_Nasc);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.mtxCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.mnsMenuPrefeito);
            this.Name = "FrmPrefeito";
            this.Text = "Formulário Prefeito";
            this.mnsMenuPrefeito.ResumeLayout(false);
            this.mnsMenuPrefeito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox mtxCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblDt_Nasc;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblRua_Av;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtxDt_Nasc;
        private System.Windows.Forms.MaskedTextBox mtxCep;
        private System.Windows.Forms.TextBox txtRua_Av;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoja;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlimento;
        private System.Windows.Forms.MenuStrip mnsMenuPrefeito;
    }
}

