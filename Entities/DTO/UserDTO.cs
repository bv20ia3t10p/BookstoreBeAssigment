using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public record UserDTO
    {
        public int Id { get; set; }
        public string? EmailAddres { get; set; }
        public string? Password { get; set; }
        public string? Source { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? RoleId { get; set; }
        public int? PublisherId { get; set; }
        public DateTime? HireDate { get; set; }
    }
    public record CreateUserDTO
    {
        public string? EmailAddres { get; set; }
        public string? Password { get; set; }
        public string? Source { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? RoleId { get; set; }
        public int? PublisherId { get; set; }
        public DateTime? HireDate { get; set; }
    }
}
