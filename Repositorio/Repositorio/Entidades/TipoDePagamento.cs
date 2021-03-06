﻿using NHibernate;
using Repositorio.DAO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class TipoDePagamento
    {
        [Key]
        public virtual int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Descricao é Necessario!")]
        [StringLength(18, MinimumLength = 3, ErrorMessage = "Campo Descricao precisa conter no minimo de 3 caracteres")]
        public virtual string Descricao { get; set; }

        public virtual IList<Pagamento> Pagamentos { get; set; }

        public virtual int Save(ISession session)
        {
            TipoDePagamentoDAO udao = new TipoDePagamentoDAO(session);
            return udao.Save(this);
        }        
        public virtual void Delete(ISession session)
        {
            TipoDePagamentoDAO udao = new TipoDePagamentoDAO(session);
            udao.Delete(this);
        }
        public virtual void Update(ISession session)
        {
            TipoDePagamentoDAO udao = new TipoDePagamentoDAO(session);
            udao.Update(this);
        }
        public virtual TipoDePagamento Find(ISession session)
        {
            TipoDePagamentoDAO udao = new TipoDePagamentoDAO(session);
            return udao.Find(Id);
        }
        public virtual IList<TipoDePagamento> List(ISession session)
        {
            TipoDePagamentoDAO udao = new TipoDePagamentoDAO(session);
            return udao.List();
        }
        public virtual IList<TipoDePagamento> BuscaPorNomeDeTipoDePagamento(ISession session)
        {
            TipoDePagamentoDAO udao = new TipoDePagamentoDAO(session);
            return udao.BuscaPorNomeDeTipoDePagamento(this);
        }
    }
}
