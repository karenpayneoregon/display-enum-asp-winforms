#nullable disable

using System.ComponentModel.DataAnnotations;
using WebApplication1.Validators;

namespace WebApplication1.Models;

public class Customer
{
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    [RequiredType(ErrorMessage = "Customer{0} can not be select")]
    public CustomerType Type { get; set; }
    public override string ToString() => Name;
}