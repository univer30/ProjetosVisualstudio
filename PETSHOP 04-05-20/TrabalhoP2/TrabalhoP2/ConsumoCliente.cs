using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
     public class ConsumoCliente
    {
        public int id_consumo { get; set; }
        public String nomeproduto { get; set; }
        public Decimal precoproduto { get; set;}
        public Decimal Precototal{ get; set; }
        public int cliente { get; set; }
        public int produto { get; set; }

    }
}
