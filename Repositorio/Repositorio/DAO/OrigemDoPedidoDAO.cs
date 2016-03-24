using NHibernate;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;


namespace Repositorio.DAO
{
    public class OrigemDoPedidoDAO : GenericDAO<OrigemDoPedido>, IOrigemDoPedidoDAO
    {
        public OrigemDoPedidoDAO(ISession session) : base(session) { }
    }
}
