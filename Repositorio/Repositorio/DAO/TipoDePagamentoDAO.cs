using NHibernate;
using NHibernate.Criterion;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;
using System.Collections.Generic;

namespace Repositorio.DAO
{
    public class TipoDePagamentoDAO : GenericDAO<TipoDePagamento>, ITipoDePagamentoDAO
    {
        public TipoDePagamentoDAO(ISession session) : base(session) { }

        public IList<TipoDePagamento> BuscaPorNomeDeTipoDePagamento(TipoDePagamento u)
        {
            ICriteria criteria = _session.CreateCriteria<TipoDePagamento>();

            if (!string.IsNullOrEmpty(u.Descricao))
            {
                criteria.Add(Restrictions.InsensitiveLike("Nome", u.Descricao, MatchMode.Anywhere));
            }
            return criteria.List<TipoDePagamento>();
        }

    }
}
