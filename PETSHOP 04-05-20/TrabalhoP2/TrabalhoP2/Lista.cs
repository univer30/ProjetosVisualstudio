using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
     public class Lista
    {
        public int Id { get; set; }
        public String p_descricao { get; set; }
        public int Id_produto { get; set; }
        public Decimal p_valorUnit { get; set; }
        public Decimal p_total { get; set; }
        public int Id_Cliente { get; set; }
        public String hora { get; set; }
        public String data { get; set; }
    }
}
