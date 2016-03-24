using NHibernate;
using Repositorio.DAO;
using System;
using System.Collections.Generic;

namespace Repositorio.Entidades
{
    public class Usuario
    {
        public virtual int Id { get; set; }
        public virtual  string Login { get; set; }
        public virtual string Senha { get; set; }
        public virtual string Nome { get; set; }
        public virtual bool Gravar { get; set; }
        public virtual bool Alterar { get; set; }
        public virtual bool Deletar { get; set; }
        public virtual IList<Pedido> Pedidos{ get; set; }

        public virtual long Adiciona(ISession session)
        {
            UsuarioDAO udao = new UsuarioDAO(session);
            return udao.Save(this);
        }
        public virtual void Deleta(ISession session)
        {
            UsuarioDAO udao = new UsuarioDAO(session);
            udao.Delete(this);
        }
        public virtual Usuario BuscaPorId(ISession session)
        {
            UsuarioDAO udao = new UsuarioDAO(session);
            Usuario u = new Usuario();
            u = udao.Find(Id);
            return u;
        }
    }
}
