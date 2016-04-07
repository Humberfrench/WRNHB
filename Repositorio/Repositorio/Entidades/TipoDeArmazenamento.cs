using NHibernate;
using Repositorio.DAO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class TipoDeArmazenamento
    {
        [Key]
        public virtual int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Descricao é Necessario!")]
        [StringLength(18, MinimumLength = 3, ErrorMessage = "Campo Descricao precisa conter no minimo de 3 caracteres")]
        public virtual string Descricao { get; set; }

        public virtual IList<Armazenamento> Armazenamentos { get; set; }

        public virtual int Save(ISession session)
        {
            TipoDeArmazenamentoDAO udao = new TipoDeArmazenamentoDAO(session);
            return udao.Save(this);
        }
        public virtual void Delete(ISession session)
        {
            TipoDeArmazenamentoDAO udao = new TipoDeArmazenamentoDAO(session);
            udao.Delete(this);
        }
        public virtual void Update(ISession session)
        {
            TipoDeArmazenamentoDAO udao = new TipoDeArmazenamentoDAO(session);
            udao.Update(this);
        }
        public virtual TipoDeArmazenamento Find(ISession session)
        {
            TipoDeArmazenamentoDAO udao = new TipoDeArmazenamentoDAO(session);
            return udao.Find(Id);
        }
        public virtual IList<TipoDeArmazenamento> List(ISession session)
        {
            TipoDeArmazenamentoDAO udao = new TipoDeArmazenamentoDAO(session);
            return udao.List();
        }
        public virtual IList<TipoDeArmazenamento> BuscaPorNomeDeTipoDeServico(ISession session)
        {
            TipoDeArmazenamentoDAO udao = new TipoDeArmazenamentoDAO(session);
            return udao.BuscaPorNomeDeTipoDeArmazenamento(this);
        }
    }
}
