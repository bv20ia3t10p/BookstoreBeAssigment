using DAO;
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
            return (IActionResult)Ok(books);
        }
        [EnableQuery]
        public IActionResult Get([FromRoute]int key) {
            Console.WriteLine();
            var book = _dao.BookDAO.GetBook(key,trackChanges: false);
            return Ok(book);
        }
        [EnableQuery]
        public IActionResult Post([FromRoute] int key,[FromBody] CreateBookDTO bookToCreate)
        {
            var book = _dao.BookDAO.CreateBook(key, bookToCreate);
            return Ok(book);
        }
        [EnableQuery]
        public IActionResult Delete([FromRoute] int key)
        {
            _dao.BookDAO.DeleteBook(key,trackChanges: false);
            return Ok();
        }
        [EnableQuery]
        public IActionResult Put([FromRoute] int key, [FromBody]  CreateBookDTO bookToPut)
        {
            var book = _dao.BookDAO.UpdateBook(key, bookToPut, trackChanges: true);
            return Ok(book);
        }


    }
}
