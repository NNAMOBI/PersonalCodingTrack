using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;

namespace WebApplication2.CompanyModel.Employee
{
    public class EmployeeRepository: IEmployeeRepository
    { 
        private readonly EmployeeDBContext _dbContext;
        public EmployeeRepository(EmployeeDBContext dbContext) 
        { 
            this._dbContext = dbContext;
        }

        public Employee Delete(int id)
        {
            Employee employee = this._dbContext.Employees.Find(id);
            if (employee != null)
            {
                _dbContext.Employees.Remove(employee);
                _dbContext.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _dbContext.Employees;
        }

        public Employee GetEmployee(int id)
        {
          return _dbContext.Employees.Find(id);
 
            
        }

        public Employee Update(Employee employee)
        {
            var employeeDetails = _dbContext.Employees.Attach(employee);
            employeeDetails.State = EntityState.Modified;
            _dbContext.SaveChanges();
            return employee;
           
        }
    }
}
