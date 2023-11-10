using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly BookstoreDbContext _context;
        private readonly Lazy<IAuthorRepository> _authorRepository;
        private readonly Lazy<IBookRepository> _bookRepository;
        public RepositoryManager( BookstoreDbContext context)
        {
            _context = context;
            _bookRepository = new Lazy<IBookRepository>(() => new BookRepository(context));
            _authorRepository = new Lazy<IAuthorRepository>(() => new AuthorRepository(context));
        } 
        public IBookRepository Book => _bookRepository.Value;
        public IAuthorRepository Author => _authorRepository.Value;
        public void Save() => _context.SaveChanges();
    }
}
