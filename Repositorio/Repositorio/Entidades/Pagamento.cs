using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    public class Pagamento
    {
        public virtual int Id { get; set; }
        public virtual decimal Valor { get; set; }
        public virtual bool Sinal { get; set; }
        public virtual decimal ValorSinal { get; set; }

        public virtual TipoDePagamento TipoDePagamento { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
