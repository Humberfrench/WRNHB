using NHibernate;
using Repositorio.DAO;

namespace Repositorio.Entidades
{
    public class ClienteCNPJ : Cliente
    {
        public virtual string CNPJ { get; set; }

        public virtual int Adiciona(ISession session)
        {
            ClienteDAOCNPJ udao = new ClienteDAOCNPJ(session);
            return udao.Save(this);
        }
        public virtual void Deleta(ISession session)
        {
            ClienteDAOCNPJ udao = new ClienteDAOCNPJ(session);
            udao.Delete(this);
        }
        public virtual ClienteCNPJ BuscaPorId(ISession session)
        {
            ClienteDAOCNPJ udao = new ClienteDAOCNPJ(session);
            return udao.Find(Id);
        }
    }
}
