public interface IEmailService
{
    Task SendConfirmationAsync(string email, AppointmentResponseDto appointment);
    Task SendReminderAsync(string email, AppointmentResponseDto appointment);
}
