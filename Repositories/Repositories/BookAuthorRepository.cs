using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class BookAuthorRepository:RepositoryBase<BookAuthor>, IBookAuthorRepository
    {
        public BookAuthorRepository( BookstoreDbContext context) : base(context) { }
        public IEnumerable<BookAuthor> GetBookAuthors(bool trackChanges) => GetAll(trackChanges);
        public IEnumerable<BookAuthor> GetBookAuthorsForAuthor(int id, bool trackChanges) => GetByCondition((c => c.AuthorId == id), trackChanges).ToList();
        public IEnumerable<BookAuthor> GetBookAuthorsForBook(int id, bool trackChanges) => GetByCondition((c => c.BookId == id), trackChanges).ToList();
        public BookAuthor GetBookAuthor(int bId, int aId, bool trackChanges) => GetByCondition((c => c.BookId == bId && c.AuthorId == aId), trackChanges).FirstOrDefault();
        public void CreateBookAuthor(BookAuthor bookAuthor) => Create(bookAuthor);
        public void DeleteBookAuthor(BookAuthor bookAuthor) => Delete(bookAuthor);
    }
}
