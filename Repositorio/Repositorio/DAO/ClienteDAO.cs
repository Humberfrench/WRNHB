using NHibernate;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;

namespace Repositorio.DAO
{
    public class ClienteDAO : GenericDAO<Cliente>, IClienteDAO
    {
        public ClienteDAO(ISession session) : base(session) { }
    }
}
