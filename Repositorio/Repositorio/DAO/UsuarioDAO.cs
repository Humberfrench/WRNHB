using NHibernate;
using NHibernate.Criterion;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;
using System.Collections.Generic;
using System;

namespace Repositorio.DAO
{
    public class UsuarioDAO : GenericDAO<Usuario>, IUsuarioDAO
    {
        public UsuarioDAO(ISession session) : base(session) { }

        public Usuario Valido(Usuario u)
        {
            string hql = "from Usuario p where p.Login = :login and p.Senha = :senha";
            IQuery query = _session.CreateQuery(hql);

            query.SetParameter("login", u.Login);
            query.SetParameter("senha", u.Senha);

            return (Usuario) query.UniqueResult();
        }
        public IList<Usuario> BuscaPorNomeDeUsuario(Usuario u)
        {
            ICriteria criteria = _session.CreateCriteria<Usuario>();

            if (!string.IsNullOrEmpty(u.Nome))
            {
                criteria.Add(Restrictions.InsensitiveLike("Nome",u.Nome, MatchMode.Anywhere));
            }
            criteria.AddOrder(Order.Desc("Id"));
            return criteria.List<Usuario>();
        }

        public IList<Usuario> BuscaOrdenado()
        {
            IList<Usuario> list = _session.CreateCriteria(typeof(Usuario)).AddOrder(Order.Asc("Id")).List<Usuario>();
            return list;            
        }
    }
}
