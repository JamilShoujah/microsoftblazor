using System.ComponentModel.DataAnnotations;

namespace microsoft_blazor_exam.Models // should now work
{

public class User
{
    [Required]
    public string Name { get; set; } = "";

    [Required]
    [EmailAddress]
    public string Email { get; set; } = "";

    public bool IsAttending { get; set; } = false;
}

}
