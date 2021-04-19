using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class frmPesquisarLivro : Form
    {
        public frmPesquisarLivro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPesquisarLivro_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();

                string sql = @"SELECT * FROM LIVROS";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvLivro.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        private void txtPesquisaLivro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();

                string sql = @"SELECT * FROM LIVROS
                    WHERE TITULO LIKE '" + txtPesquisaLivro.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvLivro.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        private void btnPesquisarLivro_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha;
            linha = dgvLivro.CurrentRow;
            Livros.CODIGO = linha.Cells["CODIGO"].Value.ToString();
            Livros.TOMBO = linha.Cells["TOMBO"].Value.ToString();
            Livros.TITULO = linha.Cells["TITULO"].Value.ToString();
            Livros.AUTOR = linha.Cells["AUTOR"].Value.ToString();
            Livros.DATA_CADASTRO = linha.Cells["DATA_CADASTRO"].Value.ToString();
            Livros.EDITORA = linha.Cells["EDITORA"].Value.ToString();
            Livros.EXEMPLAR = linha.Cells["EXEMPLAR"].Value.ToString();
            Livros.ANO_LANCAMENTO = linha.Cells["ANO_LANCAMENTO"].Value.ToString();
            Livros.COD_BARRAS = linha.Cells["COD_BARRAS"].Value.ToString();

            Close();
        }

        private void dgvLivro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha;
            linha = dgvLivro.CurrentRow;
            Livros.CODIGO = linha.Cells["CODIGO"].Value.ToString();
            Livros.TOMBO = linha.Cells["TOMBO"].Value.ToString();
            Livros.TITULO = linha.Cells["TITULO"].Value.ToString();
            Livros.AUTOR = linha.Cells["AUTOR"].Value.ToString();
            Livros.DATA_CADASTRO = linha.Cells["DATA_CADASTRO"].Value.ToString();
            Livros.EDITORA = linha.Cells["EDITORA"].Value.ToString();
            Livros.EXEMPLAR = linha.Cells["EXEMPLAR"].Value.ToString();
            Livros.ANO_LANCAMENTO = linha.Cells["ANO_LANCAMENTO"].Value.ToString();
            Livros.COD_BARRAS = linha.Cells["COD_BARRAS"].Value.ToString();

            Close();
        }
    }
}
