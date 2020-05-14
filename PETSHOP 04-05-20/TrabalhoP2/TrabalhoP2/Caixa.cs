using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
    public class Caixa
    {


        public int Id { get; set; }
        public String Data { get; set; }
        public String descricao{ get; set; }
        public String Creditodebito { get; set; }
    
        public Decimal valor { get; set; }
     
        public Decimal SaldoConta{ get; set; }
        public Decimal Subtotal { get; set; }
    }
}
