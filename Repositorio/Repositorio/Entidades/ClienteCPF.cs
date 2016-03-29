using NHibernate;
using Repositorio.DAO;

namespace Repositorio.Entidades
{
    public class ClienteCPF : Cliente
    {
        public virtual string CPF { get; set; }
        public virtual int Adiciona(ISession session)
        {
            ClienteDAOCPF udao = new ClienteDAOCPF(session);
            return udao.Save(this);
        }
        public virtual void Deleta(ISession session)
        {
            ClienteDAOCPF udao = new ClienteDAOCPF(session);
            udao.Delete(this);
        }
        public virtual ClienteCPF BuscaPorId(ISession session)
        {
            ClienteDAOCPF udao = new ClienteDAOCPF(session);
            return udao.Find(Id);
        }

    }
}
