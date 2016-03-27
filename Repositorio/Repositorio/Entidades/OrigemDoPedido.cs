using NHibernate;
using Repositorio.DAO;
using System.Collections.Generic;

namespace Repositorio.Entidades
{
    public class OrigemDoPedido
    {
        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual IList<Pedido> Pedidos { get; set; }

        public virtual long Adiciona(ISession session)
        {
            OrigemDoPedidoDAO udao = new OrigemDoPedidoDAO(session);
            return udao.Save(this);
        }
        public virtual void Deleta(ISession session)
        {
            OrigemDoPedidoDAO udao = new OrigemDoPedidoDAO(session);
            udao.Delete(this);
        }
        public virtual OrigemDoPedido BuscaPorId(ISession session)
        {
            OrigemDoPedidoDAO udao = new OrigemDoPedidoDAO(session);
            return udao.Find(Id);
        }
    }
}
