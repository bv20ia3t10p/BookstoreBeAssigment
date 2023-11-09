using DAO;
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
    }
}
