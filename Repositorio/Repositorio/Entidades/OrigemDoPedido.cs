using NHibernate;
using Repositorio.DAO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class OrigemDoPedido
    {
        [Key]
        public virtual int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Descricao é Necessario!")]
        [StringLength(18, MinimumLength = 3, ErrorMessage = "Campo Descricao precisa conter no minimo de 3 caracteres")]
        public virtual string Descricao { get; set; }
        public virtual IList<Pedido> Pedidos { get; set; }

        public virtual int Save(ISession session)
        {
            OrigemDoPedidoDAO udao = new OrigemDoPedidoDAO(session);
            return udao.Save(this);
        }
        public virtual void Delete(ISession session)
        {
            OrigemDoPedidoDAO udao = new OrigemDoPedidoDAO(session);
            udao.Delete(this);
        }
        public virtual void Update(ISession session)
        {
            OrigemDoPedidoDAO udao = new OrigemDoPedidoDAO(session);
            udao.Update(this);
        }
        public virtual OrigemDoPedido Find(ISession session)
        {
            OrigemDoPedidoDAO udao = new OrigemDoPedidoDAO(session);
            return udao.Find(Id);
        }
        public virtual IList<OrigemDoPedido> List(ISession session)
        {
            OrigemDoPedidoDAO udao = new OrigemDoPedidoDAO(session);
            return udao.List();
        }
        public virtual IList<OrigemDoPedido> BuscaPorNomeDeOrigemDePedido(ISession session)
        {
            OrigemDoPedidoDAO udao = new OrigemDoPedidoDAO(session);
            return udao.BuscaPorNomeDeOrigemDePedido(this);
        }
    }
}
