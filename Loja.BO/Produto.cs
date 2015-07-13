using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.BO
{
    public class Produto : Base
    {
        public string Descricao { get; set; }

        public string Quantidade { get; set; }
        
        public string Valor { get; set; }
        
        public string Categoria { get; set; }
    }
}
