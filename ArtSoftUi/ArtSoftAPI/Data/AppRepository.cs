
using ArtSoftAPI.Data.Model;
using ArtSoftAPI.ProxyClases.Employer;
using ArtSoftAPI.Service.LoggerService.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace ArtSoftAPI.Data
{
    public class AppRepository
    {
        private readonly AppContext _context;
        public AppRepository()
        {
            DbContextOptionsBuilder<AppContext> optionsBuilder = new DbContextOptionsBuilder<AppContext>();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ArtSofteDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _context = new AppContext(optionsBuilder.Options);
        }

        /// <summary>
        /// Лог системних помилок 
        /// </summary>
        /// <param name="errorRecord">інфоромація про помилку</param>
        /// <returns></returns>
        public async Task SetErrorAsync(ErrorRecord errorRecord)
        {
            SqlParameter[] Parameters = new SqlParameter[]
            {
                new SqlParameter("@OperationId", errorRecord.OperationId.SqlValue()),
                new SqlParameter("@ErrorMessage", errorRecord.ErrorMessage.SqlValue()),
                new SqlParameter("@StackTrace", errorRecord.StackTrace.SqlValue()),
            };

            await _context.Database.ExecuteSqlRawAsync("dbo.SetLog @OperationId, @ErrorMessage, @StackTrace", Parameters);
        }

        /// <summary>
        /// Отримання списку працівників
        /// </summary>
        /// <returns></returns>
        public async Task<List<EmployerModel>> GetEmployers()
        {
            var resp = await _context.Employers.FromSqlRaw("Exec dbo.GetAllEmployers ").ToListAsync();

            return resp;
        }
        /// <summary>
        /// Отримання працівника
        /// </summary>
        /// <returns></returns>
        public async Task<EmployerModel> GetEmployer(int id)
        {
            SqlParameter[] Parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id.SqlValue())
            };

            var resp = await _context.Employers.FromSqlRaw("dbo.GetEmployerById @Id", Parameters).ToListAsync();

            return resp.FirstOrDefault();
        }
        /// <summary>
        /// Створення працівника
        /// </summary>
        /// <returns></returns>
        public async Task<string> CreateEmployer(CreateEmployerModel employer)
        {
            var error = string.Empty;
            SqlParameter[] Parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", employer.Name.SqlValue()),
                new SqlParameter("@Surname", employer.Surname.SqlValue()),
                new SqlParameter("@Age", employer.Age.SqlValue()),
                new SqlParameter("@Gender", employer.Gender.SqlValue()),
                new SqlParameter("@Department", employer.Department.SqlValue()),
                new SqlParameter("@Language", employer.Language.SqlValue()),
            };

            try
            {
                await _context.Database.ExecuteSqlRawAsync("dbo.CreateEmployer @Name,@Surname,@Age,@Gender,@Department,@Language", Parameters);
            }
            catch (Exception ex)
            {

                error = ex.Message;
            }

            return error;
        }
        /// <summary>
        /// Оновлення працівника
        /// </summary>
        /// <returns></returns>
        public async Task<string> UpdateEmployer(UpdateEmployerModel employer)
        {
            var error = string.Empty;
            SqlParameter[] Parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", employer.Id.SqlValue()),
                new SqlParameter("@Name", employer.Name.SqlValue()),
                new SqlParameter("@Surname", employer.Surname.SqlValue()),
                new SqlParameter("@Age", employer.Age.SqlValue()),
                new SqlParameter("@Gender", employer.Gender.SqlValue()),
                new SqlParameter("@Department", employer.Department.SqlValue()),
                new SqlParameter("@Language", employer.Language.SqlValue()),
            };

            try
            {
                await _context.Database.ExecuteSqlRawAsync("dbo.UpdateEmployer @Id,@Name,@Surname,@Age,@Gender,@Department,@Language", Parameters);
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return error;
        }
        /// <summary>
        /// Видалення працівника
        /// </summary>
        /// <returns></returns>
        public async Task<string> DeleteEmployer(int employerId)
        {
            var error = string.Empty;
            SqlParameter[] Parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", employerId.SqlValue()),

            };

            try
            {
                await _context.Database.ExecuteSqlRawAsync("dbo.DeleteEmployer @Id", Parameters);
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return error;
        }
        /// <summary>
        /// Видалення працівника
        /// </summary>
        /// <returns></returns>
        public async Task<List<DepartmentModel>> GetDepartment()
        {
            var resp = await _context.DepartmentModels.FromSqlRaw("Exec dbo.GetDepartments ").ToListAsync();

            return resp;
        }
        /// <summary>
        /// Видалення Languages
        /// </summary>
        /// <returns></returns>
        public async Task<List<LanguageModel>> GetLanguages()
        {
            var resp = await _context.LanguageModels.FromSqlRaw("Exec dbo.GetLanguages").ToListAsync();

            return resp;
        }
    }
}
