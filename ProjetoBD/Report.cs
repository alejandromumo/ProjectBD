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

        public int ID_Observador { get; set; }

        public DateTime Data_Criação { get; set; }

        public int Rate { get; set; }
    }
}
