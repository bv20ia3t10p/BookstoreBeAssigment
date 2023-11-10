using AutoMapper;
using DAO.Contracts;
using Entities.DTO;
using Entities.Models;
using Repositories;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AuthorDAO : IAuthorDAO
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public AuthorDAO(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<AuthorDTO> GetAuthors(bool trackChanges)
        {
            var authors = _repository.Author.GetAuthors(trackChanges);
            var authorsToReturn = _mapper.Map<IEnumerable<AuthorDTO>>(authors);
            return authorsToReturn;

        }
        public AuthorDTO GetAuthor(int id, bool trackChanges)
        {
            var author = _repository.Author.GetAuthor(id, trackChanges);
            if (author == null)
            {
                throw new Exception("Author not found");
            }
            var authorToReturn = _mapper.Map<AuthorDTO>(author);
            return authorToReturn;
        }
        public void DeleteAuthor(int id,bool trackChanges)
        {
            var author = _repository.Author.GetAuthor(id, trackChanges);
            if (author == null)
            {
                throw new Exception("Author not found");
            }
            _repository.Author.DeleteAuthor(author);
            _repository.Save();
        }
        public AuthorDTO CreateAuthor(CreateAuthorDTO authorToCreate, bool trackChanges)
        {
            var authorEntity = _mapper.Map<Author>(authorToCreate);
            _repository.Author.CreateAuthor(authorEntity);
            _repository.Save();
            var authorToReturn = _mapper.Map<AuthorDTO>(authorEntity);
            return authorToReturn;
        }
        public AuthorDTO UpdateAuthor(int id,CreateAuthorDTO authorToUpdate,bool trackChanges)
        {
            var authorInDb = _repository.Author.GetAuthor(id, trackChanges);
            if (authorInDb == null)
            {
                throw new Exception("Author not found");
            }
            _mapper.Map(authorToUpdate, authorInDb);
            _repository.Save();
            var authorToReturn = _mapper.Map<AuthorDTO>(authorInDb);
            return authorToReturn;
        }

    }
}
