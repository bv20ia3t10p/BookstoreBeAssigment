using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("author_id")]
        public int Id { get; set; }
        [Column("last_name")]
        public string? LastName {  get; set; }
        [Column("first_name")]
        public string? FirstName { get; set;}
        [Column("phone")]
        public string? Phone {  get; set;}
        [Column("address")]
        public string? Address {  get; set; }
        [Column("city")]
        public string? City { get; set; }
        [Column("state")]
        public string? State {  get; set; }
        [Column("zip")]
        public string? Zip {  get; set; }
        [Column("email_address")]
        public string? EmailAddress {  get; set; }
    }
}
