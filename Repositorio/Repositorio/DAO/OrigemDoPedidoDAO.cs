using NHibernate;
using NHibernate.Criterion;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;
using System.Collections.Generic;

namespace Repositorio.DAO
{
    public class OrigemDoPedidoDAO : GenericDAO<OrigemDoPedido>, IOrigemDoPedidoDAO
    {
        public OrigemDoPedidoDAO(ISession session) : base(session) { }

        public IList<OrigemDoPedido> BuscaPorNomeDeOrigemDePedido(OrigemDoPedido u)
        {
            ICriteria criteria = _session.CreateCriteria<OrigemDoPedido>();

            if (!string.IsNullOrEmpty(u.Descricao))
            {
                criteria.Add(Restrictions.InsensitiveLike("Nome", u.Descricao, MatchMode.Anywhere));
            }
            return criteria.List<OrigemDoPedido>();
        }
    }
}
