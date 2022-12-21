using ArtSoftAPI.BLL.Interface;
using ArtSoftAPI.Data;
using ArtSoftAPI.ProxyClases;
using ArtSoftAPI.ProxyClases.Employer;
using ArtSoftAPI.Service.LoggerService;

namespace ArtSoftAPI.BLL.Employer
{
    public class DeleteEmployer : IRun
    {
        private DeleteEmployerReq _req;
        public async Task<Response> ExecuteAsync(Request request, LoggerService logger)
        {
            _req = request as DeleteEmployerReq;
            AppRepository repository = new AppRepository();

            var error = await repository.DeleteEmployer(_req.EmployerId);

            if (!string.IsNullOrEmpty(error))
            {
                return new DeleteEmployerResp()
                {
                    ResponseCode = CodeMessage.SW_0002

                };
            }

            return new DeleteEmployerResp()
            {
                ResponseCode = CodeMessage.SW_0001
            };
        }
    }
}