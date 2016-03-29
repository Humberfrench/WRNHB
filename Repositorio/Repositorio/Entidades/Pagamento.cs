using NHibernate;
using Repositorio.DAO;

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

        public virtual int Adiciona(ISession session)
        {
            PagamentoDAO udao = new PagamentoDAO(session);
            return udao.Save(this);
        }
        public virtual void Deleta(ISession session)
        {
            PagamentoDAO udao = new PagamentoDAO(session);
            udao.Delete(this);
        }
        public virtual Pagamento BuscaPorId(ISession session)
        {
            PagamentoDAO udao = new PagamentoDAO(session);            
            return udao.Find(Id);
        }
    }
}
