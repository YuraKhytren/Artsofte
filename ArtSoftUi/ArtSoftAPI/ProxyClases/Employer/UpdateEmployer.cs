using ArtSoftAPI.Data.Model;

namespace ArtSoftAPI.ProxyClases.Employer
{
    public class UpdateEmployerReq : Request
    {
        public UpdateEmployerModel Employer { get; set; }
    }
    public class UpdateEmployerResp : Response
    {
    }
    public class UpdateEmployerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Department { get; set; }
        public int Language { get; set; }
    }
}
