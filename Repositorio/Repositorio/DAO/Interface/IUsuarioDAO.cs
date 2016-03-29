using Repositorio.DAO.Generic;
using Repositorio.Entidades;
using System.Collections.Generic;

namespace Repositorio.DAO.Interface
{
    public interface IUsuarioDAO : IGenericDAO<Usuario>
    {
        Usuario Valido(Usuario u);
        IList<Usuario> BuscaPorNomeDeUsuario(Usuario u);
        IList<Usuario> BuscaOrdenado();
    }
}
