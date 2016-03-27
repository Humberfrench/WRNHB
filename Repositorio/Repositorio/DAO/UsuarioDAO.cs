using System;
using NHibernate;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;

namespace Repositorio.DAO
{
    public class UsuarioDAO : GenericDAO<Usuario>, IUsuarioDAO
    {
        public UsuarioDAO(ISession session) : base(session) { }

        public Usuario Valido(Usuario u)
        {
            string hql = "from Usuario p where p.Login = :login and p.Senha = :senha";
            IQuery query = base._session.CreateQuery(hql);

            query.SetParameter("login", u.Login);
            query.SetParameter("senha", u.Senha);

            return (Usuario) query.UniqueResult();
        }
    }
}
