using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetRoles(bool trackChanges);
        Role GetRole(int id, bool trackChanges);
        void CreateRole(Role role);
        void Delete(Role role);
    }
}
