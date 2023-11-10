using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IAuthorRepository
    {
        Author GetAuthor(int id, bool trackChanges);
        IEnumerable<Author> GetAuthors(bool trackChanges);
        void CreateAuthor(Author author);
        void DeleteAuthor(Author author);
    }
}
