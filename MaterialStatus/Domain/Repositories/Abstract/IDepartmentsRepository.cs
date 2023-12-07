using System;
using System.Linq;
using MaterialStatus.Domain.Entities;

namespace MaterialStatus.Domain.Repositories.Abstract
{
    public interface IDepartmentsRepository { 
        IQueryable<Department> GetDepartments();
        Department GetDepartmentById(Guid id);
        void SaveDepartment(Department department);
        void DeleteDepartment(Guid id);
    }
}
