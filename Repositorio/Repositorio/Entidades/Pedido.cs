using NHibernate;
using Repositorio.DAO;
using System;

namespace Repositorio.Entidades
{
    public class Pedido
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataPedido { get; set; }
        public virtual string Descricao { get; set; }
        public virtual bool Aplicacao { get; set; }
        public virtual string Criador { get; set; }
        public virtual DateTime DataPrevisaoLayout { get; set; }
        public virtual DateTime DataPrevisaoEntrega { get; set; }
        public virtual string HoraPrevisaoEntrega { get; set; }
        public virtual string Observacao { get; set; }
        public virtual bool Situacao  { get; set; }


        public virtual Usuario Usuario { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual OrigemDoPedido OrigemDoPedido { get; set; }
        public virtual TipoDeServico TipoDeServico { get; set; }
        public virtual Armazenamento Armazenamento { get; set; }
        public virtual Pagamento Pagamento { get; set; }

        public virtual int Adiciona(ISession session)
        {
            PedidoDAO udao = new PedidoDAO(session);
            return udao.Save(this);
        }
        public virtual void Deleta(ISession session)
        {
            PedidoDAO udao = new PedidoDAO(session);
            udao.Delete(this);
        }
        public virtual Pedido BuscaPorId(ISession session)
        {
            PedidoDAO udao = new PedidoDAO(session);
            return udao.Find(Id);
        }
    }
}
