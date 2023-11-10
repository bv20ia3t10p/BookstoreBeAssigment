using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface IBookDAO
    {
        IEnumerable<BookDTO> GetBooks(bool trackChanges);
        BookDTO GetBook(int id, bool trackChanges);
        void DeleteBook(int id, bool trackChanges);
        BookDTO CreateBook(int id,CreateBookDTO bookToCreate);
        BookDTO UpdateBook(int id, CreateBookDTO bookToUpdate, bool trackChanges);
    }
}
