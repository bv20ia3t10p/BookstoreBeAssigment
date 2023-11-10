using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers(bool trackChanges);
        User GetUser(int id,bool trackChanges);
        void CreateUser(User user);
        void DeleteUser(User user);
    }
}
