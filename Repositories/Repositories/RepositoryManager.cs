using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Contracts;
using Repositories.Repositories;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly BookstoreDbContext _context;
        private readonly Lazy<IBookRepository> _bookRepository;
        private readonly Lazy<IAuthorRepository> _authorRepository;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IRoleRepository> _roleRepository;
        private readonly Lazy<IBookAuthorRepository> _bookAuthorRepository;
        public RepositoryManager(BookstoreDbContext context)
        {
            _context = context;
            _bookRepository = new Lazy<IBookRepository>(() => new BookRepository(context));
            _authorRepository = new Lazy<IAuthorRepository>(() => new AuthorRepository(context));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(context));
            _roleRepository = new Lazy<IRoleRepository>(() => new RoleRepository(context));
            _bookAuthorRepository = new Lazy<IBookAuthorRepository>(()=> new BookAuthorRepository(context));
        }
        public IBookRepository Book => _bookRepository.Value;
        public IAuthorRepository Author => _authorRepository.Value;
        public IUserRepository User => _userRepository.Value;
        public IRoleRepository Role => _roleRepository.Value;
        public IBookAuthorRepository BookAuthor => _bookAuthorRepository.Value;
        public void Save() => _context.SaveChanges();
    }
}
