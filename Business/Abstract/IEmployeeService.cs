using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

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
