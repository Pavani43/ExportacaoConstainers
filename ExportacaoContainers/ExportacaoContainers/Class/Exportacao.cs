using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExportacaoContainers.DAO;

namespace ExportacaoContainers.Class
{
    class Exportacao:Container
    {
        private ExportacaoDAO expDAO = null;
        
        private string cod_navio;
        private string porto_saida;
        private string porto_entrega;
        
        private string data_saida;
        private string data_entrega;

        

        public string codNavio
        {
            get
            {
                return cod_navio;
            }
            set
            {
                cod_navio = value;
            }
        }

        public string portoSaida
        {
            get
            {
                return porto_saida;
            }
            set
            {
                porto_saida = value;
            }
        }

        public string portoEntrega
        {
            get
            {
                return porto_entrega;
            }
            set
            {
                porto_entrega = value;
            }
        }

        

        public string dataSaida
        {
            get
            {
                return data_saida;
            }
            set
            {
                data_saida = value;
            }
        }

        public string dataEntrega
        {
            get
            {
                return data_entrega;
            }
            set
            {
                data_entrega = value;
            }
        }

        public int ExportacaoInsert(Exportacao exp)
        {
            return expDAO.ExportacaoInsertDAO(exp);
        }
    }
}
