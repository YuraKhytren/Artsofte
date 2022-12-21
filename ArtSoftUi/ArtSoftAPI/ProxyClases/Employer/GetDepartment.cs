using ArtSoftAPI.Data.Model;

namespace ArtSoftAPI.ProxyClases.Employer
{
    public class GetDepartmentReq : Request
    {
    }
    public class GetDepartmentResp : Response
    {
        public List<DepartmentModel> DepartmentModels { get; set; }
    }
}
