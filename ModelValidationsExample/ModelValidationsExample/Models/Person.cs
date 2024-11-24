using System.ComponentModel.DataAnnotations;
using ModelValidationsExample.CustomValidators;


namespace ModelValidationsExample.Models
{
    public class Person
    {
        [Required(ErrorMessage = "{0} Can't be empty or null")]
        [Display(Name = "Person Name")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} Should be between {2} and {1} characters long")]
        [RegularExpression("^[A-Za-z .]$", ErrorMessage=("{0} sould contains only Alphabets , space and dot"))]
        public string? PersonName { get; set; }

        [EmailAddress(ErrorMessage ="{0} should be a proper email address")]
        [Required(ErrorMessage =("{0} cant be blank"))]
        public string? Email { get; set; }

        [MinimumYearValidator]
        public DateTime? DateOfBirth { get; set; }

        [Phone(ErrorMessage ="{0} should be 10 digits")]
        public string?  Phone { get; set; }

        [Required(ErrorMessage = ("{0} cant be blank"))]
        public string? Password { get; set; }

        [Required(ErrorMessage = ("{0} cant be blank"))]

        [Compare("Password",ErrorMessage =("{0} and {1} Doesnt match"))]
        [Display(Name ="Re-enter Password")]
        public string? ConfirmPassword { get; set; }

        [Range(0,999.99,ErrorMessage =("{0} Should  be between {1} and {2}"))]
        public double price { get; set; }

        public override string ToString()
        {
            return $"Person object - Person Name : {PersonName}, Email : {Email} , Phone : {Phone}, Password : {Password}, Confirm Password :{ConfirmPassword}, Price : {price}";
        }
    }
}
