using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myAPI.Models;

namespace myAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeContext;

        public EmployeeController(IEmployeeRepository employeeContext)
        {
            _employeeContext = employeeContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            List<Employee> employees = _employeeContext.GetAllEmployees();
            return employees;
        }


        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeById(int id)
        {
            var employee = _employeeContext.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }
            else return employee;
        }

    }
}
