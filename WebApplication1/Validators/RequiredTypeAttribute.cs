using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace WebApplication1.Validators;

public class RequiredTypeAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        // Invalid if null or not the right enum
        if (value is not CustomerType selection || selection == CustomerType.Select)
        {
            // Property display name (or property name if no [Display] on it)
            var displayName = validationContext.DisplayName;

            // Enum type name – what you want to show
            var typeName = value is CustomerType s
                ? s.ToString()
                : nameof(CustomerType.Select);

            // If you supplied ErrorMessage, ErrorMessageString will use it (incl. resources)
            var messageTemplate = ErrorMessageString ?? "{0} ({1}) is not allowed.";

            var message = string.Format(messageTemplate, displayName, typeName);

            return new ValidationResult(message);
        }

        return ValidationResult.Success;
    }
}