using myApp02.DAL.Entities;
using myApp02.Models.RequestViewModels;

namespace myApp02.Services.Interfaces
{
    public interface IEmployeeService
    {
        public Task<List<EmployeeResponseModel>> GetAllEmployeesAsync();
        public Task<EmployeeResponseModel> GetEmployeeByIdAsync(int id);
        public Task<string> AddEmployeeAsync(EmployeeResponseModel employee);
    }
}
