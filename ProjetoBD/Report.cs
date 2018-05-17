using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBD
{
    public class Report
    {
        public int ID { get; set; }

        public int ID_Jogador { get; set; }

        public String Username_Observador { get; set; }

        public DateTime Data_Observação { get; set; }

        public int Rate { get; set; }

        public String FullInfo
        {
            get
            {
                return $"{ID_Jogador} {Username_Observador} {Data_Observação} {Rate}";
            }
        }
    }
}
