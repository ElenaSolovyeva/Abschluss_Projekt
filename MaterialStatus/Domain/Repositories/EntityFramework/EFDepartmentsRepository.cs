using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MaterialStatus.Domain.Entities;
using MaterialStatus.Domain.Repositories.Abstract;

namespace MaterialStatus.Domain.Repositories.EntityFramework
{
    public class EFDepartmentsRepository
    {
        private readonly AppDbContext context;
        public EFDepartmentsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Department> GetUsers()
        {
            return context.Departments;
        }
        public Department GetUserById(Guid id)
        {
            return context.Departments.FirstOrDefault(department => department.Id == id);
        }

        public void SaveDepartments(Department department)
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
