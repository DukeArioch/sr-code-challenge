using challenge.Models;
using System;
using System.Threading.Tasks;

namespace challenge.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetById(String id);
        Employee Add(Employee employee);

        int GetDirectReportCount(string id);

        Employee Remove(Employee employee);
        Task SaveAsync();
    }
}