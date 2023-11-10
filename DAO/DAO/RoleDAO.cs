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
    public class RoleDAO : IRoleDAO
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public RoleDAO(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public IEnumerable<RoleDTO> GetRoles(bool trackChanges) => _mapper.Map<IEnumerable<RoleDTO>>(_repository.Role.GetRoles(trackChanges));
        public RoleDTO GetRole(int id, bool trackChanges)
        {
            var role = _repository.Role.GetRole(id,trackChanges);
            if (role == null) throw new Exception("Role not found");
            var returnRole = _mapper.Map<RoleDTO>(role);
            return returnRole;
        }
        public RoleDTO UpdateRole (int id, CreateRoleDTO role, bool trackChanges)
        {
            var roleInDb = _repository.Role.GetRole(id, trackChanges);
            if (role == null) throw new Exception("Role nto found");
            _mapper.Map(role, roleInDb);
            _repository.Save();
            return _mapper.Map<RoleDTO>(roleInDb);
        }
        public void DeleteRole(int id, bool trackChanges)
        {
            var roleInDb = _repository.Role.GetRole(id, trackChanges);
            if (roleInDb == null) throw new Exception("Role not found");
            _repository.Role.Delete(roleInDb);
            _repository.Save();
        }
        public RoleDTO CreateRole ( CreateRoleDTO role)
        {
            var roleEntity = _mapper.Map<Role>(role);
            _repository.Role.CreateRole(roleEntity);
            _repository.Save();
            return _mapper.Map<RoleDTO>(roleEntity);
        }
    }
}
