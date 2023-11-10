using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Contracts
{
    public interface IAuthorDAO
    {
        IEnumerable<AuthorDTO> GetAuthors(bool trackChanges);
        AuthorDTO GetAuthor(int id, bool trackChanges);
        void DeleteAuthor(int id, bool trackChanges);
        AuthorDTO CreateAuthor(CreateAuthorDTO authorToCreate, bool trackChanges);
        AuthorDTO UpdateAuthor(int id, CreateAuthorDTO authorToUpdate, bool trackChanges);
    }
}
