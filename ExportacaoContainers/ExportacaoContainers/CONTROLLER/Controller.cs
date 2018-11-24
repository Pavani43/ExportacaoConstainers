using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExportacaoContainers.DAO;
using ExportacaoContainers.Class;

namespace ExportacaoContainers.CONTROLLER
{
    class Controller
    {
        static ExportacaoDAO daoExp = new ExportacaoDAO();

        static public int InsertExp(Exportacao exp)
        {
            return daoExp.ExportacaoInsertDAO(exp);
        }

        static public int InsertExp(string cod_lacre, string cod_navio, float peso, string porto_saida, string porto_entrega, string data_saida, string data_entrega)
        {
            Exportacao exp = new Exportacao();
            exp.codLacre = cod_lacre;
            exp.codNavio = cod_navio;
            exp.Peso = peso;
            exp.portoSaida = porto_saida;
            exp.portoEntrega = porto_entrega;
            exp.dataSaida = data_saida;
            exp.dataEntrega = data_entrega;

            return daoExp.ExportacaoInsertDAO(exp);
        }
    }
}
