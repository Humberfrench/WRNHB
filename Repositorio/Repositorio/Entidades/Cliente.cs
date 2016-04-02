using NHibernate;
using Repositorio.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class Cliente
    {
        [Key]
        public virtual int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Nome é Necessario!")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Nome precisa conter no minimo de 3 caracteres")]
        public virtual string Nome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Documento é Necessario!")]
        [StringLength(18, MinimumLength = 3, ErrorMessage = "Nome Documento conter no minimo de 11 caracteres sem mascara e 18 com mascara")]
        public virtual string Documento { get; set; }
    
        public virtual string Endereco { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string Cidade { get; set; }

        [RegularExpression(@"^\(\d{2}\)\d{4}-\d{4}$", ErrorMessage =
            "Numero de telefone em formatação errada.")]
        public virtual string Telefone { get; set; }

        [RegularExpression(@"^\(\d{2}\)\d{5}-\d{4}$", ErrorMessage =
            "Numero de celular em formatação errada.")]
        public virtual string Celular { get; set; }

        [StringLength(10, MinimumLength = 3, ErrorMessage = "Nome Do Responsavel precisa conter no minimo de 3 caracteres")]
        public virtual string NomeDoResponsavel { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual IList<Pedido> Pedidos { get; set; }

        public virtual int Save(ISession session)
        {
            ClienteDAO udao = new ClienteDAO(session);
            return udao.Save(this);
        }
        public virtual void Update(ISession session)
        {
            ClienteDAO udao = new ClienteDAO(session);
            udao.Update(this);
        }
        public virtual void Delete(ISession session)
        {
            ClienteDAO udao = new ClienteDAO(session);
            udao.Delete(this);
        }
        public virtual Cliente Find(ISession session)
        {
            ClienteDAO udao = new ClienteDAO(session);
            return udao.Find(Id);
        }
        public virtual IList<Cliente> List(ISession session)
        {
            ClienteDAO udao = new ClienteDAO(session);
            return udao.List();
        }
    }
}
