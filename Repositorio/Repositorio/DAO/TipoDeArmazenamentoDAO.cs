using NHibernate;
using NHibernate.Criterion;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;
using System.Collections.Generic;

namespace Repositorio.DAO
{
    public class TipoDeArmazenamentoDAO : GenericDAO<TipoDeArmazenamento>, ITipoDeArmazenamentoDAO
    {
        public TipoDeArmazenamentoDAO(ISession session) : base(session) { }

        public IList<TipoDeArmazenamento> BuscaPorNomeDeTipoDeArmazenamento(TipoDeArmazenamento u)
        {
            ICriteria criteria = _session.CreateCriteria<TipoDeArmazenamento>();

            if (!string.IsNullOrEmpty(u.Descricao))
            {
                criteria.Add(Restrictions.InsensitiveLike("Nome", u.Descricao, MatchMode.Anywhere));
            }
            return criteria.List<TipoDeArmazenamento>();
        }
    }
}
