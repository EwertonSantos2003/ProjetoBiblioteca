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
    public partial class frmCadLivro : Form
    {
        public frmCadLivro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();

                string sql = @"DELETE FROM LIVROS WHERE CODIGO = @codigo";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

                cmd.Parameters.AddWithValue("codigo", Livros.CODIGO );

                cmd.ExecuteNonQuery();

                MessageBox.Show("Livro excluido com sucesso!");

                Util.LimparCampos(this);
                

                txtTombo.Focus();

                btnCadastrar.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtTombo.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtTombo, "Preencha o campo tombo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtTitulo, "");
            }

            if (txtAutor.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtAutor, "Preencha o campo autor");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtAutor, "");
            }

            if (mskDataCadastro.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskDataCadastro, "Preencha o campo Data de Cadastro");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskDataCadastro, "");
            }

            if (txtEditora.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtEditora, "Preencha o campo editora");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtEditora, "");
            }

            if (txtExemplar.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtExemplar, "Preencha o campo Exemplar");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtExemplar, "");
            }

            if (mskDataLancamento.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskDataLancamento, "Preencha o campo Data de Lançamento");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskDataLancamento, "");
            }

            if (txtCodigoDeBarras.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtCodigoDeBarras, "Preencha o campo Código de Barras");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtCodigoDeBarras, "");
            }

            try
            {
                Conexao.Conectar();
                string sql = @"INSERT INTO LIVROS ([TOMBO]
           ,[TITULO]
           ,[AUTOR]
           ,[DATA_CADASTRO]
           ,[EDITORA]
           ,[EXEMPLAR]
           ,[ANO_LANCAMENTO]
           ,[COD_BARRAS]
            ) VALUES (@tombo, @titulo,
                    @autor, @data_cadastro, @editora, @exemplar, @ano_lancamento, @cod_barras)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("tombo", txtTombo.Text);
                cmd.Parameters.AddWithValue("titulo", txtTitulo.Text);
                cmd.Parameters.AddWithValue("autor", txtAutor.Text);
                cmd.Parameters.AddWithValue("data_cadastro", mskDataCadastro.Text);
                cmd.Parameters.AddWithValue("editora", txtEditora.Text);
                cmd.Parameters.AddWithValue("exemplar", txtExemplar.Text);
                cmd.Parameters.AddWithValue("ano_lancamento", mskDataLancamento.Text);
                cmd.Parameters.AddWithValue("cod_barras", txtCodigoDeBarras.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Livro cadastrado com sucesso!");

                Util.LimparCampos(this);
                txtTombo.Focus();
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

        private void frmCadLivro_Load(object sender, EventArgs e)
        {
            mskDataCadastro.Text = DateTime.Now.ToShortDateString();
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Livros.CODIGO = "";
            frmPesquisarLivro pesq = new frmPesquisarLivro();
            pesq.ShowDialog();
            if (Livros.CODIGO != "")
            {
                txtTombo.Text = Livros.TOMBO;
                txtAutor.Text = Livros.AUTOR;
                txtTitulo.Text = Livros.TITULO;
                txtExemplar.Text = Livros.EXEMPLAR;
                txtEditora.Text = Livros.EDITORA;
                mskDataCadastro.Text = Livros.DATA_CADASTRO;
                mskDataLancamento.Text = Livros.ANO_LANCAMENTO;
                txtCodigoDeBarras.Text = Livros.COD_BARRAS;

                // Habilitar os botões Alterar e Excluir
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                // Desabilite o botão Cadastrar
                btnCadastrar.Enabled = false;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtTombo.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtTombo, "Preencha o campo TOMBO");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtTombo, "");
            }

            if (txtTitulo.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtTitulo, "Preencha o campo Titulo");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtTitulo, "");
            }

            if (txtAutor.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtAutor, "Preencha o campo Autor");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtAutor, "");
            }

            if (mskDataCadastro.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskDataCadastro, "Preencha o campo Data Cadastro");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskDataCadastro, "");
            }

            if (txtEditora.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtEditora, "Preencha o campo Editora");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtEditora, "");
            }

            if (txtExemplar.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtExemplar, "Preencha o campo Exemplar");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtExemplar, "");
            }

            if (mskDataLancamento.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskDataLancamento, "Preencha o campo Data de lançamento");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskDataLancamento, "");
            }

            if (txtCodigoDeBarras.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtCodigoDeBarras, "Preencha o campo Codigo de Barras");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtCodigoDeBarras, "");
            }

            try
            {
                Conexao.Conectar();

                string sql = @"UPDATE LIVROS SET TOMBO = @TOMBO,
                    TITULO = @TITULO, AUTOR = @AUTOR,
                    DATA_CADASTRO = @DATA_CADASTRO, EDITORA = @EDITORA, EXEMPLAR = @EXEMPLAR,
                    ANO_LANCAMENTO = @ANO_LANCAMENTO, COD_BARRAS = @COD_BARRAS
                    WHERE CODIGO = @CODIGO";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

                cmd.Parameters.AddWithValue("tombo", txtTombo.Text);
                cmd.Parameters.AddWithValue("titulo", txtTitulo.Text);
                cmd.Parameters.AddWithValue("autor", txtAutor.Text);
                cmd.Parameters.AddWithValue("data_cadastro", mskDataCadastro.Text);
                cmd.Parameters.AddWithValue("editora", txtEditora.Text);
                cmd.Parameters.AddWithValue("exemplar", txtExemplar.Text);
                cmd.Parameters.AddWithValue("ano_lancamento", mskDataLancamento.Text);
                cmd.Parameters.AddWithValue("cod_barras", txtCodigoDeBarras.Text);
                cmd.Parameters.AddWithValue("codigo", Livros.CODIGO);



                cmd.ExecuteNonQuery();

                MessageBox.Show("Livro alterado com sucesso!");


                Util.LimparCampos(this);
                txtTombo.Focus();

                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCadastrar.Enabled = true;

                mskDataCadastro.Text = DateTime.Now.ToShortDateString();


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
    }
}
