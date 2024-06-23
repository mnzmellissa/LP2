using System;
using System.Data;
using System.Data.SqlClient;

namespace PFerramenta
{
    public class Ferramenta
    {
        public int IdFerramenta { get; set; }
        public string Nome { get; set; }
        public string Fornecedor { get; set; }
        public char Distribuicao { get; set; }
        public DateTime DtCadastro { get; set; }
        public string SiteOficial { get; set; }
        public int CategoriaId { get; set; }

        public DataTable Listar()
        {
            DataTable dtFerramenta = new DataTable();
            try
            {
                using (SqlDataAdapter daFerramenta = new SqlDataAdapter("SELECT * FROM FERRAMENTA", Form1.conexao))
                {
                    daFerramenta.Fill(dtFerramenta);
                    daFerramenta.FillSchema(dtFerramenta, SchemaType.Source);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtFerramenta;
        }

        public int Salvar()
        {
            int nReg = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO FERRAMENTA (NOME, FORNECEDOR, DISTRIBUICAO, DTCADASTRO, SITEOFICIAL, CATEGORIA_idCATEGORIA) VALUES (@nome, @fornecedor, @distribuicao, @dtCadastro, @siteOficial, @categoriaId)", Form1.conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@fornecedor", Fornecedor);
                    cmd.Parameters.AddWithValue("@distribuicao", Distribuicao);
                    cmd.Parameters.AddWithValue("@dtCadastro", DtCadastro);
                    cmd.Parameters.AddWithValue("@siteOficial", SiteOficial);
                    cmd.Parameters.AddWithValue("@categoriaId", CategoriaId);
                    nReg = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }

        public int Alterar()
        {
            int nReg = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE FERRAMENTA SET NOME = @nome, FORNECEDOR = @fornecedor, DISTRIBUICAO = @distribuicao, DTCADASTRO = @dtCadastro, SITEOFICIAL = @siteOficial, CATEGORIA_idCATEGORIA = @categoriaId WHERE idFERRAMENTA = @idFerramenta", Form1.conexao))
                {
                    cmd.Parameters.AddWithValue("@idFerramenta", IdFerramenta);
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@fornecedor", Fornecedor);
                    cmd.Parameters.AddWithValue("@distribuicao", Distribuicao);
                    cmd.Parameters.AddWithValue("@dtCadastro", DtCadastro);
                    cmd.Parameters.AddWithValue("@siteOficial", SiteOficial);
                    cmd.Parameters.AddWithValue("@categoriaId", CategoriaId);
                    nReg = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }

        public int Excluir()
        {
            int nReg = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM FERRAMENTA WHERE idFERRAMENTA = @idFerramenta", Form1.conexao))
                {
                    cmd.Parameters.AddWithValue("@idFerramenta", IdFerramenta);
                    nReg = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }
    }
}
