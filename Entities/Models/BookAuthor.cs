using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [PrimaryKey(nameof(AuthorId),nameof(BookId))]
    public class BookAuthor
    {
        [Key]
        [Column("author_id")]
        public int AuthorId {  get; set; }
        public Author? Author { get; set; }
        [Key]
        [Column("book_id")]
        public int BookId {  get; set; }
        public Book? Book { get; set; }
        [Column("author_order")]
        public int? AuthorOrder {  get; set; }
        [Column("royalty_percentage")]
        public decimal? RoyaltyPercentage {  get; set; }

    }
}
