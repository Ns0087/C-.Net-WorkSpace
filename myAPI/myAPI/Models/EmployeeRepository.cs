namespace myAPI.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> lisMembers = new List<Employee>
        {
            new Employee{Id=1, FirstName="Kirtesh", LastName="Shah", Address="Vadodara" },
            new Employee{Id=2, FirstName="Nitya", LastName="Shah", Address="Vadodara" },
            new Employee{Id=3, FirstName="Dilip", LastName="Shah", Address="Vadodara" },
            new Employee{Id=4, FirstName="Atul", LastName="Shah", Address="Vadodara" },
            new Employee{Id=5, FirstName="Swati", LastName="Shah", Address="Vadodara" },
            new Employee{Id=6, FirstName="Rashmi", LastName="Shah", Address="Vadodara" },
        };
        public List<Employee> GetAllEmployees()
        {
            return lisMembers;
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = lisMembers.FirstOrDefault(emp => emp.Id == id);
            
            return employee;
        }
    }
}
