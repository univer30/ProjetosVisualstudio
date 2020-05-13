using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
    public class Pagamento
    {
        public int id { get; set; }
        public String nomecliente { get; set; }
        public Decimal dinheiro{ get; set; }
        public Decimal cartao { get; set; }
        public Decimal cheque { get; set; }
        public Decimal ticket{ get; set; }
        public Decimal descontos { get; set; }
        public Decimal outros { get; set; }
        public Decimal troco{ get; set; }
        public Decimal Total { get; set; }
        public int idCliente { get; set; }
        public String data { get; set; }
        public String hora { get; set; }


    }
}
