using NHibernate;
using Repositorio.DAO;
using System.Collections.Generic;

namespace Repositorio.Entidades
{
    public class TipoDeArmazenamento
    {
        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual IList<Armazenamento> Armazenamentos {get;set;}

        public virtual long Adiciona(ISession session)
        {
            TipoDeArmazenamentoDAO udao = new TipoDeArmazenamentoDAO(session);
            return udao.Save(this);
        }
        public virtual void Deleta(ISession session)
        {
            TipoDeArmazenamentoDAO udao = new TipoDeArmazenamentoDAO(session);
            udao.Delete(this);
        }
        public virtual TipoDeArmazenamento BuscaPorId(ISession session)
        {
            TipoDeArmazenamentoDAO udao = new TipoDeArmazenamentoDAO(session);
            return udao.Find(Id);
        }
    }
}
