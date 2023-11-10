using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Contracts;

namespace Repositories
{
    public interface IRepositoryManager
    {
        IBookRepository Book { get; }
        IAuthorRepository Author { get; }
        IUserRepository User { get; }
        IRoleRepository Role { get; }
        IBookAuthorRepository BookAuthor { get; }
        void Save();
    }
}
