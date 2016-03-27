using NHibernate;
using Repositorio.DAO;
using System.Collections.Generic;

namespace Repositorio.Entidades
{
    public class Armazenamento
    {
        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual TipoDeArmazenamento TipoDeArmazenamento { get; set; }
        public virtual IList<Pedido> Pedidos { get; set; }

        public virtual long Adiciona(ISession session)
        {
            ArmazenamentoDAO udao = new ArmazenamentoDAO(session);
            return udao.Save(this);
        }
        public virtual void Deleta(ISession session)
        {
            ArmazenamentoDAO udao = new ArmazenamentoDAO(session);
            udao.Delete(this);
        }
        public virtual Armazenamento BuscaPorId(ISession session)
        {
            ArmazenamentoDAO udao = new ArmazenamentoDAO(session);
            //Cliente u = new Cliente();            
            return udao.Find(Id);
        }

    }
}
