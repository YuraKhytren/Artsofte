using ArtSoftAPI.BLL.Interface;
using ArtSoftAPI.Data;
using ArtSoftAPI.ProxyClases;
using ArtSoftAPI.ProxyClases.Employer;
using ArtSoftAPI.Service.LoggerService;

namespace ArtSoftAPI.BLL.Employer
{
    public class GetDepartment : IRun
    {
        private GetDepartmentReq _req;
        public async Task<Response> ExecuteAsync(Request request, LoggerService logger)
        {
            _req = request as GetDepartmentReq;
            AppRepository repository = new AppRepository();

            var data = await repository.GetDepartment();

            if (data == null)
            {
                return new GetDepartmentResp()
                {
                    DepartmentModels = null,
                    ResponseCode = CodeMessage.SW_0002
                };
            }

            return new GetDepartmentResp()
            {
                DepartmentModels = data,
                ResponseCode = CodeMessage.SW_0001
            };
        }
    }
}