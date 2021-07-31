using Business.Abstract;
using Business.CrossCuttingConcerns.Validation;
using DataAccess.Abstract;
using DataAccess.CrossCuttingConcerns.Validation;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;

        }
        public void Add(Employee employee)
        {
            ValidatorTool.Validate<Employee>(employee, new EmployeeValidator());
            _employeeDal.Add(employee);


        }

        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);

        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();

        }

        public List<Employee> GetAll(Expression<Func<Employee, bool>> filter = null)
        {
            return _employeeDal.GetAll(filter);
        }

        public Employee GetById(int id)
        {
            return _employeeDal.Get(m => m.EmployeeId == id);
        }


        public void Update(Employee employee)
        {
            _employeeDal.Update(employee);

        }
    }
}
