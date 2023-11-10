using AutoMapper;
using Repositories;
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
        private readonly Lazy<IAuthorDAO> _authorDAO;
        public DAOManager(IRepositoryManager repositoryManager, IMapper mapper) {
            _bookDAO = new Lazy<IBookDAO>(() => new BookDAO(repositoryManager,mapper));
            _authorDAO = new Lazy<IAuthorDAO>(()=> new AuthorDAO(repositoryManager,mapper));
        }
        public IBookDAO BookDAO => _bookDAO.Value;
        public IAuthorDAO AuthorDAO => _authorDAO.Value;
    }
}
