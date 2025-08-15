namespace ListaDeCompras
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pibLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.libCompras = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pibLogo
            // 
            this.pibLogo.Image = global::ListaDeCompras.Properties.Resources.Logo;
            this.pibLogo.Location = new System.Drawing.Point(12, 12);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(96, 90);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogo.TabIndex = 0;
            this.pibLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(128, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(208, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Lista de Compras";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(130, 69);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(130, 18);
            this.lblNomeProduto.TabIndex = 2;
            this.lblNomeProduto.Text = "Nome do Produto:";
            // 
            // txbProduto
            // 
            this.txbProduto.Location = new System.Drawing.Point(266, 69);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(100, 20);
            this.txbProduto.TabIndex = 3;
            this.txbProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbProduto_KeyDown);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.btnAdicionar.Location = new System.Drawing.Point(281, 95);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // libCompras
            // 
            this.libCompras.FormattingEnabled = true;
            this.libCompras.Location = new System.Drawing.Point(79, 146);
            this.libCompras.Name = "libCompras";
            this.libCompras.Size = new System.Drawing.Size(455, 225);
            this.libCompras.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(133, 386);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(388, 386);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.libCompras);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txbProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibLogo);
            this.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Compras:";
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox libCompras;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
    }
}

