using System.ComponentModel.DataAnnotations;
using System.Resources;
using System.Security.AccessControl;
using System.Xml.Linq;

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