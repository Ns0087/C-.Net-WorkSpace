using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myApp02.DAL.DBContext;
using myApp02.DAL.Entities;
using myApp02.Models.RequestViewModels;
using myApp02.Services.Interfaces;

namespace myApp02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IServiceProvider serviceProvider)
        {
            _employeeService = serviceProvider.GetRequiredService<IEmployeeService>();
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeResponseModel>> GetAllEmployeesAsync()
        {
            var result = await _employeeService.GetAllEmployeesAsync();
            
            return result;
        }

        [HttpGet("{id}")]
        public async Task<EmployeeResponseModel> GetEmployeeByIdAsync(int id)
        {
            var result = await _employeeService.GetEmployeeByIdAsync(id);
            
            return result;
        }

        [HttpPost]
        public async Task<string> AddEmployeeAsync(EmployeeResponseModel employee)
        {
            return await _employeeService.AddEmployeeAsync(employee);
        }
    }
}
