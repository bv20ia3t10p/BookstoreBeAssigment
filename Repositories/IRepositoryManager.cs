using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepositoryManager
    {
        IBookRepository Book { get; }
        IAuthorRepository Author { get; }
        void Save();
    }
}
