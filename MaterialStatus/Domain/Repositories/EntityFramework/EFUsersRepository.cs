using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MaterialStatus.Domain.Entities;
using MaterialStatus.Domain.Repositories.Abstract;

namespace MaterialStatus.Domain.Repositories.EntityFramework
{
    public class EFUsersRepository : IUsersRepository
    {
        private readonly AppDbContext context;
        public EFUsersRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<User> GetUsers() 
        {
            return context.Users;
        }
        public User GetUserById(Guid id)
        {
            return context.Users.FirstOrDefault(user => user.Id == id);
        }
        
        public void SaveUser(User user)
        {
            if (user.Id == default)
                context.Entry(user).State = EntityState.Added;
            else
                context.Entry(user).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteUser(Guid id)
        {
            context.Users.Remove(new User() { Id = id});
        }
    }
}
