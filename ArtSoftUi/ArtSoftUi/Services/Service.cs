using ArtSoftUi.Models;

namespace ArtSoftUi.Services
{
    public class Service : IService
    {
        public Task CreateUserAsync(UserModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserModel>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
