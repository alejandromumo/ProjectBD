using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBD
{
    public class Utilizador
    {
        public string userName { get; set; }

        public string email { get; set; }

        public string role { get; set; }

        public DateTime? birthDate { get; set; }

        public string password { get; set; }

        public bool authenticated = false;

        public String FullInfo
        {
            get
            {
                return $"{userName} {email} {role} {authenticated}";
            }
        }
    }
}
