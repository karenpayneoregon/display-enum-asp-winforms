using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public enum CustomerType
{
    [Display(Name = "Select ...")]
    Select,
    [Display(Name = "Private")]
    PrivateSector,
    [Display(Name = "Public")]
    PublicSector
}