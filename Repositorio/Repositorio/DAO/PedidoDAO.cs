using NHibernate;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;


namespace Repositorio.DAO
{
    public class PedidoDAO : GenericDAO<Pedido>, IPedidoDAO
    {
        public PedidoDAO(ISession session) : base(session) { }
    }
}
