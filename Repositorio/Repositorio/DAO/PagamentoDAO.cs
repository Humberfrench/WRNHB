using NHibernate;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;


namespace Repositorio.DAO
{
    public class PagamentoDAO : GenericDAO<Pagamento>, IPagamentoDAO
    {
        public PagamentoDAO(ISession session) : base(session) { }
    }
}
