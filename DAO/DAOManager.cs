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
        public DAOManager(IRepositoryManager repositoryManager, IMapper mapper) {
            _bookDAO = new Lazy<IBookDAO>(() => new BookDAO(repositoryManager,mapper));
        }
        public IBookDAO BookDAO => _bookDAO.Value;
    }
}
