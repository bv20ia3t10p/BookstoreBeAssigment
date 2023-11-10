using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Contracts
{
    public interface IBookAuthorDAO
    {
        IEnumerable<BookAuthor> GetBookAuthors(bool trackChanges);
        IEnumerable<BookAuthor> GetBookAuthorsForBook(int bid, bool trackChanges);
        IEnumerable<BookAuthor> GetBookAuthorsForAuthor(int aid, bool trackChanges);
        BookAuthor GetBookAuthor(int bid,int aid, bool trackChanges);
        BookAuthor CreateBookAuthor(BookAuthor author);
        BookAuthor UpdatebookAuthor(int aid,int bid, BookAuthor author,bool trackChanges);
        void DeleteBookAuthor(int aid,int bid, bool trackChanges);
    }
}
