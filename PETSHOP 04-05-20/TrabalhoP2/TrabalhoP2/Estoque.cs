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
        public String descricao { set; get; }
        public String entrada { set; get; }
        public String saida { set; get; }
        public int unidade { set; get; }

        public int estoqueminimo { set; get; }
        public Decimal saldoAtual { set; get; }
        public int id_produto{ set; get; }



    }
}
