using ArtSoftAPI.BLL.Interface;
using ArtSoftAPI.Data;
using ArtSoftAPI.ProxyClases;
using ArtSoftAPI.ProxyClases.Employer;
using ArtSoftAPI.Service.LoggerService;

namespace ArtSoftAPI.BLL.Employer
{
    public class GetEmployer : IRun
    {
        private GetEmployerReq _req;
        public async Task<Response> ExecuteAsync(Request request, LoggerService logger)
        {
            _req = request as GetEmployerReq;
            AppRepository repository = new AppRepository();

            var data = await repository.GetEmployer(_req.EmployerId);

            if (data == null)
            {
                return new GetEmployerResp()
                {
                    Employer = null,
                    ResponseCode = CodeMessage.SW_0002

                };
            }

            return new GetEmployerResp()
            {
                Employer = data,
                ResponseCode = CodeMessage.SW_0001

            };
        }

    }
}