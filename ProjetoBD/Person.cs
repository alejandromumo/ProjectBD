using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBD
{
    public class Person
    {
        public int ID { get; set; }

        public String Nome { get; set; }

        public String Nacionalidade { get; set; }

        public DateTime DataNascimento { get; set; }

        public String FullInfo
        {
            get
            {
                return $"{Nome} {Nacionalidade} {DataNascimento}";
            }
        }
    }
}
