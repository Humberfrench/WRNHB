using NHibernate;
using Repositorio.DAO;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Entidades
{
    public class ClienteCNPJ : Cliente
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo CNPJ é Necessario!")]
        [StringLength(18, MinimumLength = 14, ErrorMessage = "Nome CNPJ conter no minimo de 14 caracteres sem mascara e 18 com mascara")]
        public virtual string CNPJ { get; set; }

        public override string ToString()
        {
            return "CNPJ";
        }
    }
}
