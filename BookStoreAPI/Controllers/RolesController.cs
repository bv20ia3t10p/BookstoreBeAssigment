using DAO;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace BookStoreAPI.Controllers
{
    public class RolesController  :ODataController
    {
        private readonly IDAOManager _dao;
        public RolesController(IDAOManager dao) {
            _dao = dao; 
        }
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_dao.RoleDAO.GetRoles(false));
        }
        [EnableQuery]
        public IActionResult Get (int key )
        {
            return Ok(_dao.RoleDAO.GetRole(key, false));
        }
        [EnableQuery]
        public IActionResult Post ( [FromBody] CreateRoleDTO newRole)
        {
            return Ok(_dao.RoleDAO.CreateRole(newRole));
        }
        [EnableQuery]
        public IActionResult Put (int key, [FromBody] CreateRoleDTO newRole)
        {
            return Ok(_dao.RoleDAO.UpdateRole(key, newRole, true));
        }
        [EnableQuery]
        public IActionResult Delete (int key)
        {
            _dao.RoleDAO.DeleteRole(key, false);
            return Ok();
        }
    }
}
