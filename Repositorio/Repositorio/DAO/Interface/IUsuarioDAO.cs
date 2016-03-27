using Repositorio.DAO.Generic;
using Repositorio.Entidades;

namespace Repositorio.DAO.Interface
{
    public interface IUsuarioDAO : IGenericDAO<Usuario>
    {
        Usuario Valido(Usuario u);
    }
}
