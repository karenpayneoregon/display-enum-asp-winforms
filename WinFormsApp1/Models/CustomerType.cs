using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.Models;

public enum CustomerType
{
    [Description("Select type...")]
    Select,
    [Description("Private")]
    PrivateSector,

    [Description("Public")]
    PublicSector
}