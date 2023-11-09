using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class User
    {
        [Column("user_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("email_address")]
        public string? EmailAddres {  get; set; }
        [Column("password")]
        public string? Password { get; set; }
        [Column("source")]
        public string? Source { get; set; }
        [Column("first_name")]
        public string? FirstName { get; set; }
        [Column("middle_name")]
        public string? MiddleName { get; set;}
        [Column("last_name")]
        public string? LastName { get; set;}
        [Column("role_id")]
        public int? RoleId {  get; set; }
        public Role? Role {  get; set; }
        [Column("pub_id")]
        public int? PubId {  get; set; }
        public Publisher? Publisher { get; set; }
        [Column("hire_date")]
        public DateTime? HireDate { get; set; }
    }
}
