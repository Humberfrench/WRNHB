using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    public abstract class Cliente
    {
        public virtual int Id { get; set; }        
        public virtual string Nome { get; set; }
        public virtual string Endereco { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string Telefone { get; set; }
        public virtual string Celular { get; set; }
        public virtual string NomeDoResponsavel { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual IList<Pedido> Pedidos { get; set; }
    }
}
