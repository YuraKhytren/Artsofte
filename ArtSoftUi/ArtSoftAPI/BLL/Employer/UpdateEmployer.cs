using ArtSoftAPI.BLL.Interface;
using ArtSoftAPI.Data;
using ArtSoftAPI.ProxyClases;
using ArtSoftAPI.ProxyClases.Employer;
using ArtSoftAPI.Service.LoggerService;

namespace ArtSoftAPI.BLL.Employer
{
    public class UpdateEmployer : IRun
    {
        private UpdateEmployerReq _req;
 
        public async Task<Response> ExecuteAsync(Request request, LoggerService logger)
        {
            _req = request as UpdateEmployerReq;
            AppRepository repository = new AppRepository();

            var error = await repository.UpdateEmployer(_req.Employer);

            if (!string.IsNullOrEmpty(error))
            {
                return new UpdateEmployerResp()
                {
                    ResponseCode = CodeMessage.SW_0002
                };
            }

            return new UpdateEmployerResp()
            {
                ResponseCode = CodeMessage.SW_0001
            };
        }
    }
}