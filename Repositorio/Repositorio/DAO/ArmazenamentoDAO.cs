using NHibernate;
using NHibernate.Criterion;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;
using System.Collections.Generic;

namespace Repositorio.DAO
{
    public class ArmazenamentoDAO : GenericDAO<Armazenamento>, IArmazenamentoDAO
    {
        public ArmazenamentoDAO(ISession session) : base(session) { }

        public IList<Armazenamento> BuscaPorNomeDeArmazenamento(Armazenamento u)
        {
            ICriteria criteria = _session.CreateCriteria<Armazenamento>();

            if (!string.IsNullOrEmpty(u.Descricao))
            {
                criteria.Add(Restrictions.InsensitiveLike("Nome", u.Descricao, MatchMode.Anywhere));
            }
            return criteria.List<Armazenamento>();
        }
    }
}
