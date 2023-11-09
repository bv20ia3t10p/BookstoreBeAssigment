using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public record CreateBookDTO
    {
        public string? Title { get; set; }
        public string? Type { get;set; }
        public int? PublisherId { get; set; }
        public decimal? Price { get; set; }
        public string? Advance {  get; set; }
        public decimal? Royalty { get; set; }
        public int? YtdSales { get; set; }
        public string? Notes { get; set; }
    }
    public record BookDTO {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Type { get; set; }
        public int? PublisherId { get; set; }
        public decimal? Price { get; set; }
        public string? Advance { get; set; }
        public decimal? Royalty { get; set; }
        public int? YtdSales { get; set; }
        public string? Notes { get; set; }
    }
}
