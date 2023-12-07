using System;
using System.Linq;
using MaterialStatus.Domain.Entities;

namespace MaterialStatus.Domain.Repositories.Abstract
{
    public interface IDepartmentsRepository
    {
        IQueryable<Department> GetDepartments();
        Department GetDepartmentById(Guid id);
        //Department GetDepartmentByName(string name);
        void SaveDepartment(Department user);
        void DeleteDepartment(Guid id);
    }
}
