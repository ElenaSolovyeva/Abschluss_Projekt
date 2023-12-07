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
        public IUsersRepository Users { get; set; }
        public IGroupsRepository Groups { get; set; }
        public IDepartmentsRepository Departments { get; set; }

        public DataManager(IUsersRepository usersRepository, IGroupsRepository groupsRepository, IDepartmentsRepository departmentsRepository)
        {
            Users = usersRepository;
            Groups = groupsRepository;
            Departments = departmentsRepository;
        }
    }
}
