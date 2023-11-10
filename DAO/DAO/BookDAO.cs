using AutoMapper;
using DAO.Contracts;
using Entities.DTO;
using Entities.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BookDAO : IBookDAO
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public BookDAO (IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public IEnumerable<BookDTO> GetBooks(bool trackChanges)
        {
            var books = _repository.Book.GetBooks(trackChanges);
            var returnBooks = _mapper.Map<IEnumerable<BookDTO>>(books);
            return returnBooks;
        }
        public BookDTO GetBook(int id,bool trackChanges) { 
            var book = _repository.Book.GetBook(id, trackChanges);
            if (book is null)
            {
                throw new Exception("Book not found");
            }
            var returnBook = _mapper.Map<BookDTO>(book);
            return returnBook;
        }
        public void DeleteBook(int id,bool trackChanges) {
            var book = _repository.Book.GetBook(id, trackChanges);
            if (book is null)
            {
                throw new Exception("Book not found");
            }
            _repository.Book.DeleteBook(book);
            _repository.Save();
        }
        public BookDTO CreateBook ( CreateBookDTO bookToCreate)
        {
            var newBookEntity = _mapper.Map<Book>(bookToCreate);
            _repository.Book.CreateBook(newBookEntity);
            _repository.Save();
            var returnBook = _mapper.Map<BookDTO>(newBookEntity);
            return returnBook;
        }
        public BookDTO UpdateBook ( int id, CreateBookDTO bookToUpdate,bool trackChanges)
        {
            var bookInDB = _repository.Book.GetBook(id,trackChanges);
            if (bookInDB == null) throw new Exception("Book not found");
            _mapper.Map(bookToUpdate, bookInDB);
            _repository.Save();
            var returnBook = _mapper.Map<BookDTO>(bookInDB);
            return returnBook;
        }
    }
}
