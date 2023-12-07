using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MaterialStatus.Domain.Entities;
using MaterialStatus.Domain.Repositories.Abstract;

namespace MaterialStatus.Domain.Repositories.EntityFramework
{
    public class EFGroupsRepository
    {
        private readonly AppDbContext context;
        public EFGroupsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Group> GetGroups()
        {
            return context.Groups;
        }
        public Group GetUserById(Guid id)
        {
            return context.Groups.FirstOrDefault(group => group.Id == id);
        }

        public void SaveUser(Group group)
        {
            if (group.Id == default)
                context.Entry(group).State = EntityState.Added;
            else
                context.Entry(group).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteGroup(Guid id)
        {
            context.Groups.Remove(new Group { Id = id });
        }

    }
}
