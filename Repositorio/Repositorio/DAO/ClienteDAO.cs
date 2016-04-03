using NHibernate;
using NHibernate.Criterion;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;
using System.Collections.Generic;

namespace Repositorio.DAO
{
    public class ClienteDAO : GenericDAO<Cliente>, IClienteDAO
    {
        public ClienteDAO(ISession session) : base(session) { }

        public IList<Cliente> BuscaPorNomeDeCliente(Cliente u)
        {
            ICriteria criteria = _session.CreateCriteria<Cliente>();

            if (!string.IsNullOrEmpty(u.Nome))
            {
                criteria.Add(Restrictions.InsensitiveLike("Nome", u.Nome, MatchMode.Anywhere));
            }
            return criteria.List<Cliente>();
        }
    }
}
