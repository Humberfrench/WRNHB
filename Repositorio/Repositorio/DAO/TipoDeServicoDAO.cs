using NHibernate;
using NHibernate.Criterion;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;
using System.Collections.Generic;

namespace Repositorio.DAO
{
    public class TipoDeServicoDAO : GenericDAO<TipoDeServico>, ITipoDeServicoDAO
    {
        public TipoDeServicoDAO(ISession session) : base(session) { }

        public IList<TipoDeServico> BuscaPorNomeDeTipoDeServico(TipoDeServico u)
        {
            ICriteria criteria = _session.CreateCriteria<TipoDeServico>();

            if (!string.IsNullOrEmpty(u.Descricao))
            {
                criteria.Add(Restrictions.InsensitiveLike("Nome", u.Descricao, MatchMode.Anywhere));
            }
            return criteria.List<TipoDeServico>();
        }
    }
}
