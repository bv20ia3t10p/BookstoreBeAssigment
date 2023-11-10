using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(BookstoreDbContext context) : base(context) { }
        public IEnumerable<Book>GetBooks(bool trackChanges) => GetAll(trackChanges).OrderBy(e=>e.Id).ToList();
        public Book GetBook(int id, bool trackChanges) => GetByCondition(e => e.Id == id, trackChanges).SingleOrDefault();
        public void DeleteBook(Book book) => Delete(book);
        public void CreateBook(Book book) => Create(book);
    }
}
