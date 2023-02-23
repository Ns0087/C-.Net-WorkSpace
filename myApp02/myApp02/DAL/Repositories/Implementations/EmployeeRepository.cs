using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using myApp02.DAL.DBContext;
using myApp02.DAL.Entities;
using myApp02.DAL.Repositories.Interfaces;

namespace myApp02.DAL.Repositories.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDBContext _employee;
        public EmployeeRepository(IServiceProvider serviceProvider)
        {
            _employee = serviceProvider.GetRequiredService<ApplicationDBContext>();
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _employee.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            var employee = await _employee.Employees.FirstOrDefaultAsync(emp => emp.Id == id);
            return employee;
        }

        public async Task<string> AddEmployeeAsync(Employee employee)
        {
            await _employee.Employees.AddAsync(employee);
            var result = await _employee.SaveChangesAsync();
            
            if(result > 0)
            {
                return "Success";
            }
            else
            {
                return "Please try again later!!";
            }
        }
    }
}
