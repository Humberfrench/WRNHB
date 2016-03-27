using NHibernate;
using Repositorio.DAO;
using System.Collections.Generic;

namespace Repositorio.Entidades
{
    public class TipoDePagamento
    {
        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual IList<Pagamento> Pagamentos { get; set; }

        public virtual long Adiciona(ISession session)
        {
            TipoDePagamentoDAO udao = new TipoDePagamentoDAO(session);
            return udao.Save(this);
        }        
        public virtual void Deleta(ISession session)
        {
            TipoDePagamentoDAO udao = new TipoDePagamentoDAO(session);
            udao.Delete(this);
        }
        public virtual TipoDePagamento BuscaPorId(ISession session)
        {
            TipoDePagamentoDAO udao = new TipoDePagamentoDAO(session);
            return udao.Find(Id);
        }
    }
}
