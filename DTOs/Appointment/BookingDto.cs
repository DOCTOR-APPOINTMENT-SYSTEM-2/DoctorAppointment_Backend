using System.ComponentModel.DataAnnotations;

public class BookingDto
{
    [Required] public int DoctorId { get; set; }
    [Required] public int TimeSlotId { get; set; }
    public string? Notes { get; set; }
}
