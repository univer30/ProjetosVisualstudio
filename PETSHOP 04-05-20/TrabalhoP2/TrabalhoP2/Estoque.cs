using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
    public class Estoque
    {
        public int id { set; get; }
        public String Data { set; get; }
        public String Descricao { set; get; }
        public int  Unidade { set; get; }
        public String Entrada { set; get; }
        public String Saida { set; get; }
        public int Estoqminimo { set; get; }
   
        public Decimal precoun { set; get; }
    }
}
