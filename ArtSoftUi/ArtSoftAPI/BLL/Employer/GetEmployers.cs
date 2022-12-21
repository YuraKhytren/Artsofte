using ArtSoftAPI.BLL.Interface;
using ArtSoftAPI.Data;
using ArtSoftAPI.ProxyClases;
using ArtSoftAPI.ProxyClases.Employer;
using ArtSoftAPI.Service.LoggerService;

namespace ArtSoftAPI.BLL.Employer
{
    public class GetEmployers : IRun
    {
        private GetEmployersReq _req;
       
        public async Task<Response> ExecuteAsync(Request request, LoggerService logger)
        {
            _req = request as GetEmployersReq;
            AppRepository repository = new AppRepository();

            var data = await repository.GetEmployers();

            if (data == null)
            {
                return new GetEmployersResp()
                {
                    Employers = null,
                    ResponseCode = CodeMessage.SW_0002

                };
            }

            return new GetEmployersResp()
            {
                Employers = data,
                ResponseCode = CodeMessage.SW_0001

            };
        }
    }
}
