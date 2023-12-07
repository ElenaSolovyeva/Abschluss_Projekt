using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MaterialStatus.Domain.Entities;
using MaterialStatus.Domain.Repositories.Abstract;

namespace MaterialStatus.Domain.Repositories.EntityFramework
{
    public class EFDepartmentsRepository : IDepartmentsRepository
    {
    
        private readonly AppDbContext context;
        public EFDepartmentsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Department> GetDepartments()
        {
            return context.Departments;
        }
        public Department GetDepartmentById(Guid id)
        {
            return context.Departments.FirstOrDefault(department => department.Id == id);
        }

        public void SaveDepartment(Department department)
        {
            if (department.Id == default)
                context.Entry(department).State = EntityState.Added;
            else
                context.Entry(department).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteDepartment(Guid id)
        {
            context.Departments.Remove(new Department() { Id = id });
        }

    }
}
