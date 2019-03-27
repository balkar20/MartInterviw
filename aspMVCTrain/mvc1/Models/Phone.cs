using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace mvc1.Models
{
    public class Phone : IValidatableObject
    {
        [HiddenInput(DisplayValue = false)]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public string Model { get; set; }
        public string Producer { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new System.NotImplementedException();
        }
    }

}