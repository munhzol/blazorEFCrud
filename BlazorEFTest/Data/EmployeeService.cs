using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorEFTest.Data
{
    public class EmployeeService
    {
        private readonly AppDBContext _db;

        public EmployeeService(AppDBContext db)
        {
            _db = db;
        }

        public List<EmployeeInfo> GetEmployee() {

            var empList = _db.Employees.ToList();
            return empList;
        }

        public string Create(EmployeeInfo emp) {
            _db.Employees.Add(emp);
            _db.SaveChanges();
            return "Success!";
        }

        public EmployeeInfo GetEmployeeById(int id)
        {
            EmployeeInfo emp = _db.Employees.FirstOrDefault(s => s.EmployeeId == id);
            return emp;
        }

        public string Update(EmployeeInfo emp)
        {
            _db.Employees.Update(emp);
            _db.SaveChanges();
            return "Success!";
        }

        public string Delete(EmployeeInfo emp)
        {
            _db.Remove(emp);
            _db.SaveChanges();
            return "Success!";
        }
    }
}
