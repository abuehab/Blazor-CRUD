using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public class EmployeeService : IRepository
    {
        #region Property
        private readonly dbContext _context;
        #endregion

        #region Constructor
        public EmployeeService(dbContext context)
        {
            _context = context;
        }
        #endregion

        #region Get List of Employees
        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }
        #endregion

        #region Insert Employee
        public async Task<bool> InsertEmployeeAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Employee by Id
        public async Task<Employee> GetEmployeeAsync(int Id)
        {
            Employee employee = await _context.Employees.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return employee;
        }
        #endregion

        #region Update Employee
        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
             _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteEmployee
        public async Task<bool> DeleteEmployeeAsync(Employee employee)
        {
            _context.Remove(employee);
            await _context.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
