using System.ComponentModel.DataAnnotations;

namespace ArtSoftAPI.Data.Model
{
    public class LanguageModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
