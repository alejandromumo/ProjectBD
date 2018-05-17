using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBD
{
    public class League
    {
        public String Nome { get; set; }

        public String DataFundação { get; set; }

        public String País { get; set; }

        public String Nome_Desporto { get; set; }

        public String URL_Externo { get; set; }


        public String FullInfo
        {
            get
            {
                return $"{Nome} {País} {Nome_Desporto}";
            }
        }
    }
}
