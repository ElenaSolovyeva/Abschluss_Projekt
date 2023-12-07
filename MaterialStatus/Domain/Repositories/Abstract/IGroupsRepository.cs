using System;
using System.Linq;
using MaterialStatus.Domain.Entities;

namespace MaterialStatus.Domain.Repositories.Abstract
{
    public interface IGroupsRepository
    {
        IQueryable<Group> GetUsers();
        Group GetGroupById(Guid id);
       // Group GetGroupByName(string name);
        void SaveGroup(Group user);
        void DeleteGroup(Guid id);
    }
}
