using System.ComponentModel.DataAnnotations;

public class SpecialtyDto
{
    public int Id { get; set; } 
    [Required] public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
}
