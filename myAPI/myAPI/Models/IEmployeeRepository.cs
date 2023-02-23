namespace myAPI.Models
{
    public interface IEmployeeRepository
    {
        public Employee GetEmployeeById(int id);
        public List<Employee> GetAllEmployees();
    }
}
