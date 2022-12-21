using ArtSoftAPI.BLL.Interface;
using ArtSoftAPI.Data;
using ArtSoftAPI.ProxyClases;
using ArtSoftAPI.ProxyClases.Employer;
using ArtSoftAPI.Service.LoggerService;

namespace ArtSoftAPI.BLL.Employer
{
    public class GetLanguages : IRun
    {
        private GetLanguagesReq _req;
        public async Task<Response> ExecuteAsync(Request request, LoggerService logger)
        {
            _req = request as GetLanguagesReq;
            AppRepository repository = new AppRepository();

            var data = await repository.GetLanguages();

            if (data == null)
            {
                return new GetLanguagesResp()
                {
                    Languages = null,
                    ResponseCode = CodeMessage.SW_0002
                };
            }

            return new GetLanguagesResp()
            {
                Languages = data,
                ResponseCode = CodeMessage.SW_0001
            };
        }
    }
}