using NHibernate;
using Repositorio.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    public class TipoDeServico
    {
        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual IList<Pedido> Pedidos { get; set; }

        public virtual int Adiciona(ISession session)
        {
            TipoDeServicoDAO udao = new TipoDeServicoDAO(session);
            return udao.Save(this);
        }
        public virtual void Deleta(ISession session)
        {
            TipoDeServicoDAO udao = new TipoDeServicoDAO(session);
            udao.Delete(this);
        }
        public virtual TipoDeServico BuscaPorId(ISession session)
        {
            TipoDeServicoDAO udao = new TipoDeServicoDAO(session);
            return udao.Find(Id);
        }
    }
}
