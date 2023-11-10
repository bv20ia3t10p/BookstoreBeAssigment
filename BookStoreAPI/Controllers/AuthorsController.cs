using DAO;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Attributes;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace BookStoreAPI.Controllers
{
    public class AuthorsController : ODataController
    {
        private readonly IDAOManager _dao;

        public AuthorsController(IDAOManager dao)
        {
            _dao = dao;
        }
        [EnableQuery]
        public IActionResult Get() => Ok
            (_dao.AuthorDAO.GetAuthors(trackChanges: false));
        [EnableQuery]
        public IActionResult Get([FromRoute] int key) =>
            Ok(_dao.AuthorDAO.GetAuthor(key, trackChanges: false));
        [EnableQuery]
        public IActionResult Post([FromBody] CreateAuthorDTO authorToCreate)
            => Ok(_dao.AuthorDAO.CreateAuthor(authorToCreate, trackChanges: false));
        [EnableQuery]
        public IActionResult Delete([FromRoute] int key)
        {
            _dao.AuthorDAO.DeleteAuthor(key, trackChanges: false);
            return Ok();
        }
        [EnableQuery]
        public IActionResult Put([FromRoute] int key, [FromBody] CreateAuthorDTO authorToUpdate)
        {
            var updatedAuthor = _dao.AuthorDAO.UpdateAuthor(key, authorToUpdate, trackChanges: true);
            return Ok(updatedAuthor);
        }
    }
}
