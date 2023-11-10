using AutoMapper;
using DAO.Contracts;
using Entities.DTO;
using Entities.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    public class UserDAO: IUserDAO
    {
        private IRepositoryManager _repository;
        private IMapper _mapper;
        public UserDAO(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public IEnumerable<UserDTO> GetUsers(bool trackChanges)
        {
            var users = _repository.User.GetUsers(trackChanges);
            var usersToReturn = _mapper.Map<IEnumerable<UserDTO>>(users);
            return usersToReturn;
        }
        public UserDTO GetUser(int id, bool trackChanges)
        {
            var user = _repository.User.GetUser(id, trackChanges);
            if (user == null) throw new Exception("User not found");
            var userToReturn = _mapper.Map<UserDTO>(user);
            return userToReturn;
        }
        public UserDTO CreateUser(CreateUserDTO user)
        {
            var userEntity = _mapper.Map<User>(user);
            _repository.User.CreateUser(userEntity);
            _repository.Save();
            var userToReturn = _mapper.Map<UserDTO>(userEntity);
            return userToReturn;
        }
        public UserDTO UpdateUser(int id, CreateUserDTO user, bool trackChanges)
        {
            var userInDb = _repository.User.GetUser(id,trackChanges);
            if (userInDb == null) throw new Exception("User not found");
            _mapper.Map(user, userInDb);
            _repository.Save();
            var userToReturn = _mapper.Map<UserDTO>(userInDb);
            return userToReturn;
        }
        public void DeleteUser(int id, bool trackChanges)
        {
            var userInDb = _repository.User.GetUser(id, trackChanges);
            if (userInDb == null) throw new Exception("User not found");
            _repository.User.DeleteUser(userInDb);
            _repository.Save();
        }
    }
}
