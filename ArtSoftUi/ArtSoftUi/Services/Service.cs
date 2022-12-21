using ArtSoftUi.Models;
using ArtSoftUi.ProxyClases;
using Newtonsoft.Json;
using System.Text;

namespace ArtSoftUi.Services
{
    public class Service : IService
    {
        public Task CreateUserAsync(UserModel model)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserModel>> GetAllUsersAsync()
        {
            GetAllEmployersResp respList = new GetAllEmployersResp();
            List<UserModel> users = new List<UserModel>();
            string resp = string.Empty;
            GetAllEmployersReq req = new GetAllEmployersReq();


            using (HttpClient httpClient = new HttpClient())
            {
                HttpContent content = new StringContent(JsonConvert.SerializeObject(req), Encoding.UTF8, "application/json");
              
                HttpResponseMessage response = await httpClient.PostAsync(@"https://localhost:7288/Employer/GetEmployers", content);
                response.EnsureSuccessStatusCode();

                resp = await response.Content.ReadAsStringAsync();
            }

            respList = JsonConvert.DeserializeObject<GetAllEmployersResp>(resp);
            users = respList.Employers;

            return users;
        }

        public async Task<UserModel> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateUserAsync(UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
