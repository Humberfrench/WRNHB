using NHibernate;
using Repositorio.DAO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class Armazenamento
    {
        [Key]
        public virtual int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Descricao é Necessario!")]
        [StringLength(18, MinimumLength = 3, ErrorMessage = "Campo Descricao precisa conter no minimo de 3 caracteres")]
        public virtual string Descricao { get; set; }

        public virtual TipoDeArmazenamento TipodeArmazenamento { get; set; }
        public virtual IList<Pedido> Pedidos { get; set; }

        public virtual int Save(ISession session)
        {
            ArmazenamentoDAO udao = new ArmazenamentoDAO(session);
            return udao.Save(this);
        }
        public virtual void Delete(ISession session)
        {
            ArmazenamentoDAO udao = new ArmazenamentoDAO(session);
            udao.Delete(this);
        }
        public virtual void Update(ISession session)
        {
            ArmazenamentoDAO udao = new ArmazenamentoDAO(session);
            udao.Update(this);
        }
        public virtual Armazenamento Find(ISession session)
        {
            ArmazenamentoDAO udao = new ArmazenamentoDAO(session);
            return udao.Find(Id);
        }
        public virtual IList<Armazenamento> List(ISession session)
        {
            ArmazenamentoDAO udao = new ArmazenamentoDAO(session);
            return udao.List();
        }
        public virtual IList<Armazenamento> BuscaPorNomeDeArmazenamento(ISession session)
        {
            ArmazenamentoDAO udao = new ArmazenamentoDAO(session);
            return udao.BuscaPorNomeDeArmazenamento(this);
        }

    }
}
