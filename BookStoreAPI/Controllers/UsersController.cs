using DAO;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace BookStoreAPI.Controllers
{
    public class UsersController : ODataController
    {
        private readonly IDAOManager _dao;
        public UsersController(IDAOManager dao)
        {
            _dao = dao;
        }
        [EnableQuery]
        public IActionResult Get() => Ok(_dao.UserDAO.GetUsers(trackChanges: false));
        [EnableQuery]
        public IActionResult Get(int key) => Ok(_dao.UserDAO.GetUser(key, false));
        [EnableQuery]
        public IActionResult Post([FromBody] CreateUserDTO user) => Ok(_dao.UserDAO.CreateUser(user));
        [EnableQuery]
        public IActionResult Delete(int key)
        {
            _dao.UserDAO.DeleteUser(key, false); 
            return Ok();
        }
        [EnableQuery]
        public IActionResult Put([FromBody] CreateUserDTO user, int key) => Ok(_dao.UserDAO.UpdateUser(key,user,true));
    }
}
