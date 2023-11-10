using AutoMapper;
using DAO.Contracts;
using DAO.DAO;
using Repositories;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOManager : IDAOManager
    {
        private readonly Lazy<IBookDAO> _bookDAO;
        private readonly Lazy<IBookAuthorDAO> _bookAuthorDAO;
        private readonly Lazy<IAuthorDAO> _authorDAO;
        private readonly Lazy<IUserDAO> _userDAO;
        private readonly Lazy<IRoleDAO> _roleDAO;
        public DAOManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _bookDAO = new Lazy<IBookDAO>(() => new BookDAO(repositoryManager, mapper));
            _authorDAO = new Lazy<IAuthorDAO>(() => new AuthorDAO(repositoryManager, mapper));
            _userDAO = new Lazy<IUserDAO>(() => new UserDAO(repositoryManager, mapper));
            _roleDAO = new Lazy<IRoleDAO>(() => new RoleDAO(repositoryManager,mapper));
            _bookAuthorDAO = new Lazy<IBookAuthorDAO> (()=>new BookAuthorDAO(repositoryManager,mapper));
        }
        public IBookAuthorDAO BookAuthorDAO => _bookAuthorDAO.Value;
        public IBookDAO BookDAO => _bookDAO.Value;
        public IAuthorDAO AuthorDAO => _authorDAO.Value;
        public IUserDAO UserDAO => _userDAO.Value;
        public IRoleDAO RoleDAO => _roleDAO.Value;
    }
}
