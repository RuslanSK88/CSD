using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace CSD.Web.Models;

[DisplayColumn("Категория")]
public class Category
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Имя")]
    [Required]
    public string? Name { get; set; }

    [Display(Name = "Родительская категория")]
    [Required]
    public int ParentId { get; set; } = 0;

    public List<Post>? Posts { get; set; }
}


