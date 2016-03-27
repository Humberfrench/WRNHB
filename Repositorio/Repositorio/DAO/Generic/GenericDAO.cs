using NHibernate;
using System.Collections.Generic;

namespace Repositorio.DAO.Generic
{
    public abstract class GenericDAO<T> : IGenericDAO<T>
    {
        protected ISession _session;

        public GenericDAO(ISession session)
        {
            _session = session;
        }

        public long Save(T entity)
        {
            return (int) _session.Save(entity);
        }
        public void Update(T entity)
        {
            _session.Update(entity);
        }
        public void Delete(T entity)
        {
            _session.Delete(entity);
        }
        public T Find(int id)
        {
            return _session.Get<T>(id);
        }
        public IList<T> List()
        {
            IList<T> list = _session.CreateCriteria(typeof(T)).List<T>();
            return list;
        }        
    }
}

