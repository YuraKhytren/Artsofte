using ArtSoftAPI.Data.Model;

namespace ArtSoftAPI.ProxyClases.Employer
{
    public class GetLanguagesReq : Request
    {
    }
    public class GetLanguagesResp : Response
    {
        public List<LanguageModel> Languages { get; set; }
    }
}
