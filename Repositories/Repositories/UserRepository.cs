using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(BookstoreDbContext context) : base(context) { }
        public IEnumerable<User> GetUsers(bool trackChanges) => GetAll(trackChanges).ToList();
        public User GetUser(int id, bool trackChanges) => GetByCondition((c => c.Id == id), trackChanges).SingleOrDefault();
        public void CreateUser(User user) => Create(user);
        public void DeleteUser(User user) => Delete(user);
    }
}
