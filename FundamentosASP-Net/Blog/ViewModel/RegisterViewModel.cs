using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels;
public class RegisterViewModel
{
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public string Email { get; set; } = null!;

}