using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public interface IRepository
    {

        Task<List<Employee>> GetAllEmployeesAsync();
        Task<bool> InsertEmployeeAsync(Employee employee);
        Task<Employee> GetEmployeeAsync(int Id);
        Task<bool> UpdateEmployeeAsync(Employee employee);
        Task<bool> DeleteEmployeeAsync(Employee employee);
    }
}
