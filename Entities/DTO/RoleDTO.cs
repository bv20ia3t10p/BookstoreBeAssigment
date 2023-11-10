using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public record RoleDTO
    {
        public int Id { get; set; }
        public string? Description { get; set; }

    }
    public record CreateRoleDTO
    {
        public string? Description { get; set; }
    }
}
