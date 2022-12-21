using ArtSoftAPI.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace ArtSoftAPI.Data
{
    public class AppContext : DbContext
    {
        public AppContext() : base()
        {
        }
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
     
        }
        
        public DbSet<EmployerModel> Employers { get; set; }
        public DbSet<DepartmentModel> DepartmentModels { get; set; }
        public DbSet<LanguageModel> LanguageModels { get; set; }

    }


}
