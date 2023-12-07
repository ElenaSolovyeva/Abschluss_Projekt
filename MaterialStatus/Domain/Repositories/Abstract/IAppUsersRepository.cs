using System;
using System.Linq;
using MaterialStatus.Domain.Entities;

namespace MaterialStatus.Domain.Repositories.Abstract
{
    public interface IAppUsersRepository
    {
        IQueryable<AppUser> GetAppUsers();
        AppUser GetAppUserById(Guid id);
        void SaveAppUser(AppUser user);
        void DeleteAppUser(Guid id);
    }
}
