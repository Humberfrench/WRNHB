using NHibernate;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;


namespace Repositorio.DAO
{
    public class TipoDePagamentoDAO : GenericDAO<TipoDePagamento>, ITipoDePagamentoDAO
    {
        public TipoDePagamentoDAO(ISession session) : base(session) { }
    }
}
