using AutoMapper;
using DAO;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace BookStoreAPI.Controllers
{
    public class AuthorController : ODataController
    {
        private readonly IDAOManager _dao;
        private readonly IMapper _mapper;

        public AuthorController(IDAOManager dao, IMapper mapper)
        {
            _dao = dao;
            _mapper = mapper;
        }
        [EnableQuery]
        public IActionResult Get() => (IActionResult)Ok
            (_dao.AuthorDAO.GetAuthors(trackChanges: false));
        [EnableQuery]
        public IActionResult Get([FromRoute] int key) =>
            Ok(_dao.AuthorDAO.GetAuthor(key, trackChanges: false));
        [EnableQuery]
        public IActionResult Post([FromBody] CreateAuthorDTO authorToCreate)
            => Ok(_dao.AuthorDAO.CreateAuthor(authorToCreate, trackChanges: false));
        [EnableQuery]
        public IActionResult Delete([FromRoute] int key)
        {   var authorInDb = _dao.AuthorDAO.GetAuthor(key, trackChanges: false);
            if (authorInDb is null)
            {
                throw new Exception("Author not found");
            }
            _dao.AuthorDAO.DeleteAuthor(key, trackChanges: false);
            return Ok();
        }
            public IActionResult Put([FromRoute] int key, [FromBody] CreateAuthorDTO authorToUpdate) 
        {
            var authorInDb = _dao.AuthorDAO.GetAuthor(key, trackChanges: false);
            if (authorInDb is null)
            {
                throw new Exception("Author not found");
            }
            _mapper.Map(authorToUpdate, authorInDb);
            var authorToReturn = _mapper.Map<AuthorDTO>(authorInDb)
            return Ok();
        }
        }
    }
