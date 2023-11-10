using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(BookstoreDbContext context) : base(context) { }
        public Author GetAuthor(int id, bool trackChanges) => GetByCondition(c => c.Id == id, trackChanges).FirstOrDefault();
        public IEnumerable<Author> GetAuthors(bool trackChanges) => GetAll(trackChanges).ToList();
        public void CreateAuthor(Author author) => Create(author);
        public void DeleteAuthor(Author author) => Delete(author);

    }
}
