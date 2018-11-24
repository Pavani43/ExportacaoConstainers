using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportacaoContainers.Class
{
    class Container
    {
        private string cod_lacre;
        private float peso;

        public string codLacre
        {
            get
            {
                return cod_lacre;
            }

            set
            {
                cod_lacre = value;
            }
        }

        public float Peso
        {
            get
            {
                return peso;
            }
            set
            {
                peso = value;
            }
        }
    }
}
