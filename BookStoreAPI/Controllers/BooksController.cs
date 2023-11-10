using DAO;
using DAO.Contracts;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace BookStoreAPI.Controllers
{
    public class BooksController : ODataController
    {
        private readonly IDAOManager _dao;
        public BooksController(IDAOManager dao ) { 
            _dao = dao;
        }
        [EnableQuery]
        public IActionResult Get()
        {
            var books = _dao.BookDAO.GetBooks(trackChanges: false);
            return Ok(books);
        }
        [EnableQuery]
        public IActionResult Get(int key)
        {
            var book = _dao.BookDAO.GetBook(key,trackChanges: false);
            return Ok(book);
        }
        [EnableQuery]
        public IActionResult Put(int key,[FromBody] CreateBookDTO bookToUpdate)
        {
            var updatedBook = _dao.BookDAO.UpdateBook(key,bookToUpdate,trackChanges:true);
            return Ok(updatedBook);
        }
        [EnableQuery]
        public IActionResult Delete(int key)
        {
            _dao.BookDAO.DeleteBook(key,trackChanges:false);
            return Ok();
        }
        [EnableQuery]
        public IActionResult Post([FromBody]CreateBookDTO bookToCreate)
        {
            var createdBook = _dao.BookDAO.CreateBook(bookToCreate);
            return Ok(createdBook);
        }
    }
}
