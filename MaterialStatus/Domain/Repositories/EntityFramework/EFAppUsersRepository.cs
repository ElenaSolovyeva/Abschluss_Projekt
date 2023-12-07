using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MaterialStatus.Domain.Entities;
using MaterialStatus.Domain.Repositories.Abstract;

namespace MaterialStatus.Domain.Repositories.EntityFramework
{
    public class EFAppUsersRepository : IAppUsersRepository
    {
        private readonly AppDbContext context;
        public EFAppUsersRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<AppUser> GetAppUsers() 
        {
            return context.AppUsers;
        }
        public AppUser GetAppUserById(Guid id)
        {
            return context.AppUsers.FirstOrDefault(appUser => appUser.Id == id);
        }
        
        public void SaveAppUser(AppUser appUser)
        {
            if (appUser.Id == default)
                context.Entry(appUser).State = EntityState.Added;
            else
                context.Entry(appUser).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteAppUser(Guid id)
        {
            context.AppUsers.Remove(new AppUser() { Id = id});
        }
    }
}
