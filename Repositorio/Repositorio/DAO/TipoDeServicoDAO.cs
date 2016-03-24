using NHibernate;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;


namespace Repositorio.DAO
{
    public class TipoDeServicoDAO : GenericDAO<ITipoDeServicoDAO>, ITipoDeServicoDAO
    {
        public TipoDeServicoDAO(ISession session) : base(session) { }
    }
}
