using NHibernate;
using Repositorio.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    public class TipoDeServico
    {
        [Key]
        public virtual int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Descricao é Necessario!")]
        [StringLength(18, MinimumLength = 3, ErrorMessage = "Nome Descricao conter no minimo de 3 caracteres")]
        public virtual string Descricao { get; set; }

        public virtual IList<Pedido> Pedidos { get; set; }

        public virtual int Save(ISession session)
        {
            TipoDeServicoDAO udao = new TipoDeServicoDAO(session);
            return udao.Save(this);
        }
        public virtual void Delete(ISession session)
        {
            TipoDeServicoDAO udao = new TipoDeServicoDAO(session);
            udao.Delete(this);
        }
        public virtual void Update(ISession session)
        {
            TipoDeServicoDAO udao = new TipoDeServicoDAO(session);
            udao.Update(this);
        }
        public virtual TipoDeServico Find(ISession session)
        {
            TipoDeServicoDAO udao = new TipoDeServicoDAO(session);
            return udao.Find(Id);
        }
        public virtual IList<TipoDeServico> List(ISession session)
        {
            TipoDeServicoDAO udao = new TipoDeServicoDAO(session);
            return udao.List();
        }
        public virtual IList<TipoDeServico> BuscaPorNomeDeTipoDeServico(ISession session)
        {
            TipoDeServicoDAO udao = new TipoDeServicoDAO(session);
            return udao.BuscaPorNomeDeTipoDeServico(this);
        }
    }
}
