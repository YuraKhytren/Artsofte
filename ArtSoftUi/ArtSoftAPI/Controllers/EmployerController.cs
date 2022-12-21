using ArtSoftAPI.BLL;
using ArtSoftAPI.BLL.Employer;
using ArtSoftAPI.ProxyClases;
using ArtSoftAPI.ProxyClases.Employer;
using ArtSoftAPI.Service.LoggerService;
using Microsoft.AspNetCore.Mvc;

namespace ArtSoftAPI.Controllers
{
    /// <summary>
    /// Контролер для Працівників
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        private readonly LoggerService _logger;
        public EmployerController(LoggerService loggerService) 
        { 
            _logger = loggerService;
        }


        /// <summary>
        /// Ендпоінт для отримання даних про співробітників
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<GetEmployersResp> GetEmployers(GetEmployersReq request) 
        {
            Run run = new Run(_logger);
            Response response = await run.ExecuteAsync(new GetEmployers(), request);

            if (response is GetEmployersResp)
                return response as GetEmployersResp;
            else
                return new GetEmployersResp() { ResponseCode = response.ResponseCode };
        }
        /// <summary>
        /// Ендпоінт для отримання даних про співробітника
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<GetEmployerResp> GetEmployerById(GetEmployerReq request)
        {
            Run run = new Run(_logger);
            Response response = await run.ExecuteAsync(new GetEmployer(), request);

            if (response is GetEmployerResp)
                return response as GetEmployerResp;
            else
                return new GetEmployerResp() { ResponseCode = response.ResponseCode };
        }

        /// <summary>
        /// Створення співробітника
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<CreateEmployerResp> CreateEmployer(CreateEmployerReq request)
        {
            Run run = new Run(_logger);
            Response response = await run.ExecuteAsync(new CreateEmployer(), request);

            if (response is CreateEmployerResp)
                return response as CreateEmployerResp;
            else
                return new CreateEmployerResp() { ResponseCode = response.ResponseCode };
        }

        /// <summary>
        /// Оновлення даних співробітника
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<UpdateEmployerResp> UpdateEmployer(UpdateEmployerReq request)
        {
            Run run = new Run(_logger);
            Response response = await run.ExecuteAsync(new UpdateEmployer(), request);

            if (response is UpdateEmployerResp)
                return response as UpdateEmployerResp;
            else
                return new UpdateEmployerResp() { ResponseCode = response.ResponseCode };
        }
        /// <summary>
        /// Видалення співробітника
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<DeleteEmployerResp> DeleteEmployer(DeleteEmployerReq request)
        {
            Run run = new Run(_logger);
            Response response = await run.ExecuteAsync(new DeleteEmployer(), request);

            if (response is DeleteEmployerResp)
                return response as DeleteEmployerResp;
            else
                return new DeleteEmployerResp() { ResponseCode = response.ResponseCode };
        }
        /// <summary>
        /// Отримання Department
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<GetDepartmentResp> GetDepartment(GetDepartmentReq request)
        {
            Run run = new Run(_logger);
            Response response = await run.ExecuteAsync(new GetDepartment(), request);

            if (response is GetDepartmentResp)
                return response as GetDepartmentResp;
            else
                return new GetDepartmentResp() { ResponseCode = response.ResponseCode };
        }
        /// <summary>
        /// Отримання Department
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<GetLanguagesResp> GetLanguages(GetLanguagesReq request)
        {
            Run run = new Run(_logger);
            Response response = await run.ExecuteAsync(new GetLanguages(), request);

            if (response is GetLanguagesResp)
                return response as GetLanguagesResp;
            else
                return new GetLanguagesResp() { ResponseCode = response.ResponseCode };
        }
    }
}
