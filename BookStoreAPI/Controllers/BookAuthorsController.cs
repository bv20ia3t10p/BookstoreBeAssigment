using DAO;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Attributes;
using Microsoft.AspNetCore.OData.Routing.Controllers;
//using System.Web.Http.OData;

namespace BookStoreAPI.Controllers
{
    public class BookAuthorsController : ODataController
    {
        private readonly IDAOManager _dao;
        public BookAuthorsController(IDAOManager dao) => _dao = dao;
        [EnableQuery]
        public IActionResult Get() => Ok(_dao.BookAuthorDAO.GetBookAuthors(false));
        [HttpGet("odata/BookAuthors/{bid}/{aid}")]
        public IActionResult GetBookAuthor(int bid, int aid) => Ok(_dao.BookAuthorDAO.GetBookAuthor(bid, aid, false));
        [EnableQuery]
        [HttpGet("odata/BookAuthors/Book/{BookId}")]
        public IActionResult GetByBookId(int BookId) => Ok(_dao.BookAuthorDAO.GetBookAuthorsForBook(BookId, false));
        [EnableQuery]
        [HttpGet("odata/BookAuthors/Author/{AuthorId}")]
        public IActionResult GetByAuthorId(int AuthorId) => Ok(_dao.BookAuthorDAO.GetBookAuthorsForAuthor(AuthorId, false));
        [EnableQuery]
        public IActionResult Post([FromBody] BookAuthor author) => Ok(_dao.BookAuthorDAO.CreateBookAuthor(author));
        [EnableQuery]
        public IActionResult Put([FromBody] BookAuthor author) => Ok(_dao.BookAuthorDAO.UpdatebookAuthor(author.BookId, author.AuthorId, author, true));
        [EnableQuery]
        [HttpDelete("odata/BookAuthors/{bid}/{aid}")]

        public IActionResult Delete(int aid, int bid)
        {
            _dao.BookAuthorDAO.DeleteBookAuthor(aid, bid, false);
            return Ok();
        }

    }
}
