using AutoMapper;
using DAO.Contracts;
using Entities.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    public class BookAuthorDAO : IBookAuthorDAO
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public BookAuthorDAO(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public BookAuthor CreateBookAuthor(BookAuthor author)
        {
            _repository.BookAuthor.CreateBookAuthor(author);
            _repository.Save();
            return author;
        }

        public void DeleteBookAuthor(int aid, int bid, bool trackChanges)
        {
            var baInDB = _repository.BookAuthor.GetBookAuthor(bid, aid, trackChanges);
            if (baInDB == null) throw new Exception("Book authoring not found");
            _repository.BookAuthor.DeleteBookAuthor(baInDB);
            _repository.Save();
        }

        public BookAuthor GetBookAuthor(int bid, int aid, bool trackChanges)
        {
            return _repository.BookAuthor.GetBookAuthor(bid,aid,trackChanges);
        }

        public IEnumerable<BookAuthor> GetBookAuthorsForAuthor(int aid, bool trackChanges)
        {
            return _repository.BookAuthor.GetBookAuthorsForAuthor(aid,trackChanges);
        }

        public IEnumerable<BookAuthor> GetBookAuthorsForBook(int bid, bool trackChanges)
        {
            return _repository.BookAuthor.GetBookAuthorsForBook(bid,trackChanges);
        }

        public IEnumerable<BookAuthor> GetBookAuthors(bool trackChanges)
        {
            return _repository.BookAuthor.GetBookAuthors(trackChanges);
        }

        public BookAuthor UpdatebookAuthor(int aid, int bid, BookAuthor author, bool trackChanges)
        {
            var baInDB = _repository.BookAuthor.GetBookAuthor(bid,aid, trackChanges);
            if (baInDB == null) throw new Exception("Book authoring nt found");
            baInDB = author;
            _repository.Save();
            return baInDB;
        }
    }
}
