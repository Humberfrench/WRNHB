using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Annotation
{
    public class ValidateObjectAttribute : ValidationAttribute
    {
        public bool ValidarTodasPropriedades { get; private set; }

        public ValidateObjectAttribute(bool validartodaspropriedades)
        {
            this.ValidarTodasPropriedades = validartodaspropriedades;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(value, null, null);

            Validator.TryValidateObject(value, context, results, true);

            if (results.Count != 0)
            {
                if (ValidarTodasPropriedades)
                {
                    var compositeResults = new CompositeValidationResult(String.Format(base.ErrorMessage + " {0}!", validationContext.DisplayName));
                    results.ForEach(compositeResults.AddResult);

                    return compositeResults;
                }
                else
                {
                    var compositeResults = new CompositeValidationResult(String.Format(base.ErrorMessage + " {0}!", validationContext.DisplayName));
                    return compositeResults;
                }                                
            }

            return ValidationResult.Success;
        }
    }
    public class CompositeValidationResult : ValidationResult
    {
        private readonly List<ValidationResult> _results = new List<ValidationResult>();

        public IEnumerable<ValidationResult> Results
        {
            get
            {
                return _results;
            }
        }

        public CompositeValidationResult(string errorMessage) : base(errorMessage) { }
        public CompositeValidationResult(string errorMessage, IEnumerable<string> memberNames) : base(errorMessage, memberNames) { }
        protected CompositeValidationResult(ValidationResult validationResult) : base(validationResult) { }

        public void AddResult(ValidationResult validationResult)
        {
            _results.Add(validationResult);
        }
    }
}
