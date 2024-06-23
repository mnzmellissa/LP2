using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PFerramenta
{
    public partial class Form1 : Form
    {
        public static SqlConnection conexao;
        private BindingSource bnFerramenta = new BindingSource();
        private DataSet dsFerramenta = new DataSet();
        private bool bInclusao = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=PC-008\\MSSQLSERVER01;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
                MessageBox.Show("Conexão aberta com sucesso!");

                Categoria cat = new Categoria();
                DataTable dtCategoria = cat.Listar();
                cbxCategoria.DataSource = dtCategoria;
                cbxCategoria.DisplayMember = "DESCRICAO";
                cbxCategoria.ValueMember = "idCATEGORIA";

                Ferramenta ferramenta = new Ferramenta();
                dsFerramenta.Tables.Add(ferramenta.Listar());
                bnFerramenta.DataSource = dsFerramenta.Tables["FERRAMENTA"];
                dgvFerramenta.DataSource = bnFerramenta;

                txtNome.DataBindings.Add("Text", bnFerramenta, "NOME");
                txtFornecedor.DataBindings.Add("Text", bnFerramenta, "FORNECEDOR");
                txtDistribuicao.DataBindings.Add("Text", bnFerramenta, "DISTRIBUICAO");
                dtpCadastro.DataBindings.Add("Value", bnFerramenta, "DTCADASTRO");
                txtSiteOficial.DataBindings.Add("Text", bnFerramenta, "SITEOFICIAL");
                cbxCategoria.DataBindings.Add("SelectedValue", bnFerramenta, "CATEGORIA_idCATEGORIA");

                HabilitarBotoes(true);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados = " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros = " + ex.Message);
            }
        }

        private void HabilitarBotoes(bool estado)
        {
            btnNovo.Enabled = estado;
            btnSalvar.Enabled = !estado;
            btnAlterar.Enabled = estado;
            btnExcluir.Enabled = estado;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            bInclusao = true;
            bnFerramenta.AddNew();
            HabilitarBotoes(false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Ferramenta ferramenta = new Ferramenta
                {
                    Nome = txtNome.Text,
                    Fornecedor = txtFornecedor.Text,
                    Distribuicao = txtDistribuicao.Text[0],
                    DtCadastro = dtpCadastro.Value,
                    SiteOficial = txtSiteOficial.Text,
                    CategoriaId = (int)cbxCategoria.SelectedValue
                };

                if (bInclusao)
                {
                    ferramenta.Salvar();
                }
                else
                {
                    DataRowView rowView = bnFerramenta.Current as DataRowView;
                    if (rowView != null)
                    {
                        ferramenta.IdFerramenta = (int)rowView["idFERRAMENTA"];
                        ferramenta.Alterar();
                    }
                }

                dsFerramenta.Tables.Clear();
                dsFerramenta.Tables.Add(ferramenta.Listar());
                bnFerramenta.DataSource = dsFerramenta.Tables["FERRAMENTA"];
                HabilitarBotoes(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            bInclusao = false;
            HabilitarBotoes(false);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o Current é do tipo DataRowView
                DataRowView rowView = bnFerramenta.Current as DataRowView;
                if (rowView != null)
                {
                    int idFerramenta = (int)rowView["idFERRAMENTA"];

                    Ferramenta ferramenta = new Ferramenta
                    {
                        IdFerramenta = idFerramenta
                    };
                    ferramenta.Excluir();

                    dsFerramenta.Tables.Clear();
                    dsFerramenta.Tables.Add(ferramenta.Listar());
                    bnFerramenta.DataSource = dsFerramenta.Tables["FERRAMENTA"];
                }
                else
                {
                    MessageBox.Show("Nenhum registro selecionado para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnFerramenta.CancelEdit();
            HabilitarBotoes(true);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}