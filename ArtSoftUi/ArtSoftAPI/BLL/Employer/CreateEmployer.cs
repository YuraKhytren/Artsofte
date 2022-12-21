using ArtSoftAPI.BLL.Interface;
using ArtSoftAPI.Data;
using ArtSoftAPI.ProxyClases;
using ArtSoftAPI.ProxyClases.Employer;
using ArtSoftAPI.Service.LoggerService;

namespace ArtSoftAPI.BLL.Employer
{
    public class CreateEmployer : IRun
    {
        private CreateEmployerReq _req;
       
        public async Task<Response> ExecuteAsync(Request request, LoggerService logger)
        {
            _req = request as CreateEmployerReq;
            AppRepository repository = new AppRepository();

            var error = await repository.CreateEmployer(_req.Employer);

            if (!string.IsNullOrEmpty(error))
            {
                return new CreateEmployerResp()
                {
                    ResponseCode = CodeMessage.SW_0002

                };
            }

            return new CreateEmployerResp()
            {
                ResponseCode = CodeMessage.SW_0001
            };
        }
    }
}