using ArtSoftUi.Models;

namespace ArtSoftUi.ProxyClases
{
    public class GetAllEmployersReq
    {
      
    }
    public class GetAllEmployersResp
    {
        public List<UserModel> Employers { get; set; }
        public ResponseBody ResponseBody { get; set; }
    }
}
