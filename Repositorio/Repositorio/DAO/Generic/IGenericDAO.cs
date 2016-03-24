using System.Collections.Generic;

namespace Repositorio.DAO.Generic
{
    public interface IGenericDAO<T>
    {
        long Save(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Find(long id);
        IList<T> List(); 

    }
}
