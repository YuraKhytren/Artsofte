using ArtSoftAPI.Data.Model;

namespace ArtSoftAPI.ProxyClases.Employer
{
    public class GetEmployersReq : Request
    {
        
    }
    public class GetEmployersResp : Response
    {
      public List<EmployerModel> Employers { get; set; }
    }

}
