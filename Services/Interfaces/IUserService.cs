public interface IUserService
{
    Task<List<UserProfileDto>> GetAllUsersAsync();
    Task<UserProfileDto> GetUserByIdAsync(int id);
    Task<bool> DeactivateUserAsync(int id);
}
