using Repositorio.Entidades;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Annotation
{   
    public class ValidaComboBoxAttribute : ValidationAttribute
    {
        public string Valor { get; private set; }
        public string ValorComparacao { get; private set; }

        public ValidaComboBoxAttribute(string valor,string valorcomparacao)
        {
            this.Valor = valor;
            this.ValorComparacao = valorcomparacao;
        }

        public override bool IsValid(object value)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(value);

            object valor = properties.Find(Valor, true).GetValue(value);
            object valorcomparacao = properties.Find(ValorComparacao, true).GetValue(value);

            if (valor == valorcomparacao)
            {
                return false;
            }

            return true;
        }
    }
}
