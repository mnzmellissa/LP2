using System;
using System.Data;
using System.Data.SqlClient;


namespace PFerramenta
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descricao { get; set; }

        public DataTable Listar()
        {
            DataTable dtCategoria = new DataTable();
            try
            {
                using (SqlDataAdapter daCategoria = new SqlDataAdapter("SELECT * FROM Categoria", Form1.conexao))
                {
                    daCategoria.Fill(dtCategoria);
                    daCategoria.FillSchema(dtCategoria, SchemaType.Source);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCategoria;
        }
    }
}
