using NHibernate;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;


namespace Repositorio.DAO
{
    public class TipoDeArmazenamentoDAO : GenericDAO<TipoDeArmazenamento>, ITipoDeArmazenamentoDAO
    {
        public TipoDeArmazenamentoDAO(ISession session) : base(session) { }
    }
}
