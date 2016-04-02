using NHibernate;
using Repositorio.DAO.Interface;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class ClienteCPF : Cliente
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo CPF é Necessario!")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "Nome CPF conter no minimo de 11 caracteres sem mascara e 14 com mascara")]
        public virtual string CPF { get; set; }

        public override string ToString()
        {
            return "CPF";
        }
    }
}
