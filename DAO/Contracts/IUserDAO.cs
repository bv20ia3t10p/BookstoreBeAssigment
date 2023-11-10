using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Contracts
{
    public interface IUserDAO
    {
        IEnumerable<UserDTO> GetUsers(bool trackChanges);
        UserDTO GetUser(int id,bool trackChanges);
        UserDTO CreateUser(CreateUserDTO userToCreate);
        UserDTO UpdateUser(int id,CreateUserDTO userToUpdate, bool trackChanges);
        void DeleteUser(int id,bool trackChanges);
    }
}
