using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using mvc1.Models;

namespace mvc1.Validation
{
    public class BookPropertyValidator : ModelValidator
    {
        public BookPropertyValidator(ModelMetadata metadata, ControllerContext context)
            : base(metadata, context)
        { }

        public override IEnumerable<ModelValidationResult> Validate(object container)
        {
            Book b = container as Book;
            if (b != null)
            {
                switch (Metadata.PropertyName)
                {
                    case "Name":
                        if (string.IsNullOrEmpty(b.Name))
                        {
                            return new ModelValidationResult[]{
                                new ModelValidationResult { MemberName="Name", Message="Введите название книги"}
                            };
                        }
                        break;
                    case "Author":
                        if (string.IsNullOrEmpty(b.Author))
                        {
                            return new ModelValidationResult[]{
                                new ModelValidationResult { MemberName="Author", Message="Введите автора книги"}
                            };
                        }
                        break;
                    case "Year":
                        if (b.Year > 2000 || b.Year < 1700)
                        {
                            return new ModelValidationResult[]{
                                new ModelValidationResult { MemberName="Year", Message="Недопустимый год"}
                            };
                        }
                        break;
                }
            }
            return Enumerable.Empty<ModelValidationResult>();
        }
    }
}