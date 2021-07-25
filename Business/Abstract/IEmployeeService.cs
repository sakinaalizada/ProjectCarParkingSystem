using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
        List<Employee> GetAll(Expression<Func<Employee, bool>> filter = null);
        Employee GetById(int id);
    }
}
