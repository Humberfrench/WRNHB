using NHibernate;
using Repositorio.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class Usuario
    {
        [Key]
        public virtual int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Login é Necessario!")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Login precisa conter no minimo de 3 caracteres")]
        public virtual string Login { get;  set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Senha é Necessario!")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Senha precisa conter no minimo de 3 caracteres")]
        [DataType(DataType.Password)]
        public virtual string Senha { get;  set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Nome é Necessario!")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Números e caracteres especiais não são permitidos no Nome.")]
        public virtual string Nome { get;  set; }

        [Range(typeof(bool), "false", "true", ErrorMessage = "Escolha um!")]
        public virtual bool Gravar { get;  set; }

        [Range(typeof(bool), "false", "true", ErrorMessage = "Escolha um!")]
        public virtual bool Alterar { get;  set; }

        [Range(typeof(bool), "false", "true", ErrorMessage = "Escolha um!")]
        public virtual bool Deletar { get;  set; }

        public virtual IList<Pedido> Pedidos{ get; set; }

        public virtual int Save(ISession session)
        {
            UsuarioDAO udao = new UsuarioDAO(session);
            return udao.Save(this);            
        }
        public virtual void Update(ISession session)
        {
            UsuarioDAO udao = new UsuarioDAO(session);
            udao.Update(this);
        }
        public virtual void Delete(ISession session)
        {
            UsuarioDAO udao = new UsuarioDAO(session);
            udao.Delete(this);
        }
        public virtual Usuario Find(ISession session)
        {
            UsuarioDAO udao = new UsuarioDAO(session);
            return udao.Find(Id);
        }
        public virtual Usuario Valido(ISession session)
        {
            UsuarioDAO udao = new UsuarioDAO(session);
            return udao.Valido(this);
        }
        public virtual IList<Usuario> List(ISession session)
        {
            UsuarioDAO udao = new UsuarioDAO(session);
            return udao.List();
        }
        public virtual IList<Usuario> BuscaPorNomeDeUsuario(ISession session)
        {
            UsuarioDAO udao = new UsuarioDAO(session);
            return udao.BuscaPorNomeDeUsuario(this);
        }
    }
}
