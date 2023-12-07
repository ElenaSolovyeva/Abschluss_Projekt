using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialStatus.Domain.Repositories.Abstract;

namespace MaterialStatus.Domain
{
    public class DataManager
    {
        public IAppUsersRepository AppUsers { get; set; }
        public IGroupsRepository Groups { get; set; }
        public IDepartmentsRepository Departments { get; set; }

        public DataManager(IAppUsersRepository usersRepository, IGroupsRepository groupsRepository, IDepartmentsRepository departmentsRepository)
        {
            AppUsers = usersRepository;
            Groups = groupsRepository;
            Departments = departmentsRepository;
        }
    }
}
