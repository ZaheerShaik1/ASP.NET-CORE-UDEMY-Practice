using System.ComponentModel.DataAnnotations;

namespace ModelValidationsExample.CustomValidators
{
    public class MinimumYearValidator : ValidationAttribute
    {
        public int MinimumYear { get; set; } = 2000;
        public MinimumYearValidator()
        {
            
        }
        public MinimumYearValidator(int minimumYear)
        {
            MinimumYear = minimumYear;
            
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value != null)
            {
                DateTime date = (DateTime)value;
                if(date.Year >=MinimumYear)
                {
                    return new ValidationResult("Minimum year allowed is 2000");
                }
                else
                {
                    return ValidationResult.Success;
                }

            }
            return null;
        }
    }
}
