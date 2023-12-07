using System;
using System.Linq;
using MaterialStatus.Domain.Entities;

namespace MaterialStatus.Domain.Repositories.Abstract
{
    public interface IGroupsRepository
    {
        IQueryable<Group> GetGroups();
        Group GetGroupById(Guid id);
        void SaveGroup(Group group);
        void DeleteGroup(Guid id);
    }
}
