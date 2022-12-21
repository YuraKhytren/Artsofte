using System.ComponentModel.DataAnnotations;

namespace ArtSoftAPI.Data.Model
{
    public class EmployerModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string Language { get; set; }
    }

}
