using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Contracts;

namespace DAO
{
    public interface IDAOManager
    {
        IBookDAO BookDAO { get; }
        IAuthorDAO AuthorDAO { get; }
        IUserDAO UserDAO { get; }
        IRoleDAO RoleDAO { get; }
        IBookAuthorDAO BookAuthorDAO { get; }
    }
}
