using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBookRepository
    {
        public IEnumerable<Book> GetBooks(bool trackChanges);
        public Book GetBook(int id, bool trackChanges);
        public void CreateBook(Book book);
        public void DeleteBook(Book book);
    }
}
