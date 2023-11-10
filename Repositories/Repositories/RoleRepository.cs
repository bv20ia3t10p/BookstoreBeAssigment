using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository 
    {
        public RoleRepository(BookstoreDbContext context) : base(context) { }
        public IEnumerable<Role> GetRoles(bool trackChanges) => GetAll(trackChanges).ToList();
        public Role GetRole(int id, bool trackChanges) => GetByCondition((c => c.Id == id), trackChanges).FirstOrDefault();
        public void CreateRole(Role role) => Create(role);
        public void DeleteRole(Role role) => Delete(role);
    }
}
