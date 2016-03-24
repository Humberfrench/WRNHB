using NHibernate;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;

namespace Repositorio.DAO
{
    public class ArmazenamentoDAO : GenericDAO<Armazenamento>, IArmazenamentoDAO
    {
        public ArmazenamentoDAO(ISession session) : base(session) { }
    }
}
