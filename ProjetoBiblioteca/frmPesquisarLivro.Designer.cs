
namespace ProjetoBiblioteca
{
    partial class frmPesquisarLivro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisaLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisarLivro = new System.Windows.Forms.Button();
            this.dgvLivro = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOMBO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CADASTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXEMPLAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANO_LANCAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_BARRAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtPesquisaLivro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtPesquisaLivro
            // 
            this.txtPesquisaLivro.Location = new System.Drawing.Point(207, 27);
            this.txtPesquisaLivro.Name = "txtPesquisaLivro";
            this.txtPesquisaLivro.Size = new System.Drawing.Size(323, 20);
            this.txtPesquisaLivro.TabIndex = 27;
            this.txtPesquisaLivro.TextChanged += new System.EventHandler(this.txtPesquisaLivro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Digite o nome do livro:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.btnPesquisarLivro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::ProjetoBiblioteca.Properties.Resources.shut_down_icon;
            this.btnSair.Location = new System.Drawing.Point(716, 32);
            this.btnSair.Margin = new System.Windows.Forms.Padding(11);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 48);
            this.btnSair.TabIndex = 4;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesquisarLivro
            // 
            this.btnPesquisarLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarLivro.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisarLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarLivro.FlatAppearance.BorderSize = 0;
            this.btnPesquisarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarLivro.Image = global::ProjetoBiblioteca.Properties.Resources.magnifier;
            this.btnPesquisarLivro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarLivro.Location = new System.Drawing.Point(19, 32);
            this.btnPesquisarLivro.Margin = new System.Windows.Forms.Padding(11);
            this.btnPesquisarLivro.Name = "btnPesquisarLivro";
            this.btnPesquisarLivro.Size = new System.Drawing.Size(150, 48);
            this.btnPesquisarLivro.TabIndex = 3;
            this.btnPesquisarLivro.Text = "Pesquisar";
            this.btnPesquisarLivro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarLivro.UseVisualStyleBackColor = false;
            this.btnPesquisarLivro.Click += new System.EventHandler(this.btnPesquisarLivro_Click);
            // 
            // dgvLivro
            // 
            this.dgvLivro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.TOMBO,
            this.TITULO,
            this.AUTOR,
            this.DATA_CADASTRO,
            this.EDITORA,
            this.EXEMPLAR,
            this.ANO_LANCAMENTO,
            this.COD_BARRAS});
            this.dgvLivro.Location = new System.Drawing.Point(0, 96);
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivro.Size = new System.Drawing.Size(786, 257);
            this.dgvLivro.TabIndex = 25;
            this.dgvLivro.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivro_CellContentDoubleClick);
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Visible = false;
            this.CODIGO.Width = 74;
            // 
            // TOMBO
            // 
            this.TOMBO.DataPropertyName = "TOMBO";
            this.TOMBO.HeaderText = "TOMBO";
            this.TOMBO.Name = "TOMBO";
            this.TOMBO.Width = 71;
            // 
            // TITULO
            // 
            this.TITULO.DataPropertyName = "TITULO";
            this.TITULO.HeaderText = "TITULO";
            this.TITULO.Name = "TITULO";
            this.TITULO.Width = 71;
            // 
            // AUTOR
            // 
            this.AUTOR.DataPropertyName = "AUTOR";
            this.AUTOR.HeaderText = "AUTOR";
            this.AUTOR.Name = "AUTOR";
            this.AUTOR.Width = 70;
            // 
            // DATA_CADASTRO
            // 
            this.DATA_CADASTRO.DataPropertyName = "DATA_CADASTRO";
            this.DATA_CADASTRO.HeaderText = "DATA_CADASTRO";
            this.DATA_CADASTRO.Name = "DATA_CADASTRO";
            this.DATA_CADASTRO.Width = 126;
            // 
            // EDITORA
            // 
            this.EDITORA.DataPropertyName = "EDITORA";
            this.EDITORA.HeaderText = "EDITORA";
            this.EDITORA.Name = "EDITORA";
            this.EDITORA.Width = 80;
            // 
            // EXEMPLAR
            // 
            this.EXEMPLAR.DataPropertyName = "EXEMPLAR";
            this.EXEMPLAR.HeaderText = "EXEMPLAR";
            this.EXEMPLAR.Name = "EXEMPLAR";
            this.EXEMPLAR.Width = 90;
            // 
            // ANO_LANCAMENTO
            // 
            this.ANO_LANCAMENTO.DataPropertyName = "ANO_LANCAMENTO";
            this.ANO_LANCAMENTO.HeaderText = "ANO_LANCAMENTO";
            this.ANO_LANCAMENTO.Name = "ANO_LANCAMENTO";
            this.ANO_LANCAMENTO.Width = 135;
            // 
            // COD_BARRAS
            // 
            this.COD_BARRAS.DataPropertyName = "COD_BARRAS";
            this.COD_BARRAS.HeaderText = "COD_BARRAS";
            this.COD_BARRAS.Name = "COD_BARRAS";
            this.COD_BARRAS.Width = 105;
            // 
            // frmPesquisarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.dgvLivro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPesquisarLivro";
            this.Text = "frmPesquisarLivro";
            this.Load += new System.EventHandler(this.frmPesquisarLivro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPesquisarLivro;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvLivro;
        private System.Windows.Forms.TextBox txtPesquisaLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOMBO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CADASTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDITORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXEMPLAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANO_LANCAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_BARRAS;
    }
}