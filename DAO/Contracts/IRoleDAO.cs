using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Contracts
{
    public interface IRoleDAO
    {
        IEnumerable<RoleDTO> GetRoles(bool trackChanges);
        RoleDTO GetRole(int id, bool trackChanges);
        RoleDTO CreateRole(CreateRoleDTO role);
        RoleDTO UpdateRole(int id,CreateRoleDTO role,  bool trackChanges);
        void DeleteRole(int id,bool trackChanges);
    }
}
