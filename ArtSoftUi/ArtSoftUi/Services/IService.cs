using ArtSoftUi.Models;

namespace ArtSoftUi.Services
{
    public interface IService
    {
        Task<List<UserModel>> GetAllUsersAsync();
        Task<UserModel> GetUserByIdAsync(int id);
        Task CreateUserAsync(UserModel model);
        Task UpdateUserAsync(UserModel model);
        Task DeleteUserAsync(int id);
    }
}
