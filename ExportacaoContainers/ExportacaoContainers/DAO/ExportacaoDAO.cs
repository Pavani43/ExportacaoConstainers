using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ExportacaoContainers.Class;
using System.Windows.Forms;

namespace ExportacaoContainers.DAO
{
    class ExportacaoDAO
    {
        internal int ExportacaoInsertDAO(Exportacao exp)
        {
            int retorno = 0;

            using (var conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    var comandoSQL = new StringBuilder();
                    comandoSQL.Append("INSERT INTO Tabela(cod_lacre, cod_navio, peso, porto_saida, porto_entrega, data_saida, data_entrega)");
                    comandoSQL.Append("VALUES (@cod_lacre, @cod_navio, @peso, @porto_saida, @porto_entrega, @data_saida, @data_entrega)");
                    SqlCommand comando = new SqlCommand(comandoSQL.ToString(), conn);
                    comando.Parameters.AddWithValue("@cod_lacre", exp.codLacre);
                    comando.Parameters.AddWithValue("@cod_navio", exp.codNavio);
                    comando.Parameters.AddWithValue("@peso", exp.Peso);
                    comando.Parameters.AddWithValue("@porto_saida", exp.portoSaida);
                    comando.Parameters.AddWithValue("@porto_entrega", exp.portoEntrega);
                    comando.Parameters.AddWithValue("@data_saida", exp.dataSaida);
                    comando.Parameters.AddWithValue("@data_entrega", exp.dataEntrega);
                    retorno = comando.ExecuteNonQuery();
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

            return retorno;
        }
    }
}
