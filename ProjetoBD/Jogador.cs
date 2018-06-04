using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBD
{
    public class Jogador
    {
        public String playerName { get; set; }

        public String clubName { get; set; }

        public String position { get; set; }

        public String URL { get; set; }

        public String Nationality { get; set; }

        public DateTime? BirthDate { get; set; }

        public int? Height { get; set; }

        public int? Weight { get; set; }

        public int? ID_Externo { get; set; }

        public int playerID { get; set; }
    }
}
