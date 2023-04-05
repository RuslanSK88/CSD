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
    [Required(ErrorMessage = "Обязательное поле")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Длина должна быть от 3 до 100 символов")]
    public string? Name { get; set; }

    [Display(Name = "Родительская категория")]
    [Required(ErrorMessage = "Обязательное поле")]
    public int ParentId { get; set; } = 0;

    public List<Post>? Posts { get; set; }
}


