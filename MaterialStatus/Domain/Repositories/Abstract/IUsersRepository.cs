using System;
using System.Linq;
using MaterialStatus.Domain.Entities;

namespace MaterialStatus.Domain.Repositories.Abstract
{
    public interface IUsersRepository
    {
        IQueryable<User> GetUsers();
        User GetUserById(Guid id);

        //User GetUserByName(string name);
        void SaveUser(User user);
        void DeleteUser(Guid id);
    }
}
