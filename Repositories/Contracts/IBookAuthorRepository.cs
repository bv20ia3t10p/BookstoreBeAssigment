using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IBookAuthorRepository
    {
        IEnumerable<BookAuthor> GetBookAuthors(bool trackChanges);
        IEnumerable<BookAuthor> GetBookAuthorsForBook(int id,bool trackChanges);
        IEnumerable<BookAuthor> GetBookAuthorsForAuthor(int id, bool trackChanges);
        BookAuthor GetBookAuthor(int bId,int aId, bool trackChanges);
        void CreateBookAuthor(BookAuthor author);
        void DeleteBookAuthor(BookAuthor author);
    }
}
