using System.ComponentModel.DataAnnotations;

namespace ArtSoftAPI.Data.Model
{
    public class DepartmentModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
