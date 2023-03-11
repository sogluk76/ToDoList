using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace MyFruits.Models;

public class Fruit
{
    public int Id { get; set; }
    [StringLength(50, MinimumLength =1)]
    [Required]
    [Display(Name ="Nom")]

    public string? Name { get; set; }

    public string? Description { get; set; }


    [DataType(DataType.Currency)]
    [Required]
    [Display(Name = "prix")]
    public string Price { get; set; }

}
