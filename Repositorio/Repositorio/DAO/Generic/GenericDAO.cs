using NHibernate;
using System;
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

        public int Save(T entity)
        {            
            return (int)_session.Save(entity);
        }
        public void Update(T entity)
        {            
            using (ITransaction transaction = _session.BeginTransaction())
            {
                try
                {
                    _session.Update(entity);
                    transaction.Commit();
                }
                catch (HibernateException he)
                {
                    throw new Exception(he.InnerException.Message);
                }
            }            
        }
        public void Delete(T entity)
        {
            using (ITransaction transaction = _session.BeginTransaction())
            {
                try
                {
                    _session.Delete(entity);
                }
                catch (HibernateException he)
                {
                    throw new Exception(he.InnerException.Message);
                }
            }
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

