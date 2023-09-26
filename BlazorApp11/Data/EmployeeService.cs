using BlazorApp11.Context;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp11.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDBContext _applicationDbContext; 
        public EmployeeService(ApplicationDBContext applicationDBContext)
        {
            _applicationDbContext = applicationDBContext;
        }
        // Get all Employee List
        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _applicationDbContext.Employees.ToListAsync();

        }
        //Add new Employee Record
        public async Task<bool> AddEmployees(Employee employee)
        {
            await _applicationDbContext.Employees.AddAsync(employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;

        }
        //Get Employee By Id
        public async Task<Employee> GetEmployeeById(int id)
         {
            Employee employee = await _applicationDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);

            return employee;
         

        }
        //Update Employee 
        public async Task<bool> UpdateEmployee(Employee employee)
        {
            _applicationDbContext.Employees.Update(employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete Employee 
        public async Task<bool> DeleteEmployee(Employee employee)
        {
            _applicationDbContext.Employees.Remove (employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

    }
}
