using ArtSoftAPI.Data.Model;

namespace ArtSoftAPI.ProxyClases.Employer
{
    public class GetEmployerReq : Request
    {
        public int EmployerId { get; set; }
    }
    public class GetEmployerResp : Response
    {
        public EmployerModel Employer { get; set; }
    }
}
