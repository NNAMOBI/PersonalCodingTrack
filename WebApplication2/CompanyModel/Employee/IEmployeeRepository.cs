namespace WebApplication2.CompanyModel.Employee
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAll();

        Employee Update(Employee employee);
        Employee Delete(int id);
    }
}
