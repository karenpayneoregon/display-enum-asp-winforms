using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.Validators;

public class RequiredTypeAttribute : RequiredAttribute
{
    public override bool IsValid(object? value)
    {
        if (value is null) return false;

        if (value is CustomerType selection)
        {
            return selection != CustomerType.Select;
        }

        return false;
    }
}