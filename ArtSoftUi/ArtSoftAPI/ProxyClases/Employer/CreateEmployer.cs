using ArtSoftAPI.Data.Model;

namespace ArtSoftAPI.ProxyClases.Employer
{
    public class CreateEmployerReq : Request
    {
        public CreateEmployerModel Employer { get; set; }
    }
    public class CreateEmployerResp : Response
    {
    }
    public class CreateEmployerModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Department { get; set; }
        public int Language { get; set; }
    }
}
