using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Book
    {
        [Column("book_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("title")]
        public string? Title { get; set; }
        [Column("type")]
        public string? Type { get; set; }
        [Column("pub_id")]
        public int? PubId { get; set; }
        public Publisher? Publisher { get; set; }
        [Column("price")]
        public decimal? Price {  get; set; }
        [Column("advance")]
        public string? Advance {  get; set; }
        [Column("royalty")]
        public decimal? Royalty { get; set; }
        [Column("ytd_sales")]
        public int? YtdSales { get; set; }
        [Column("notes")]
        public string? Notes { get; set; }
        [Column("published_date")]
        public DateTime? PublishedDate {  get; set; }
    }
}
