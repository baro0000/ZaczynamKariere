using System.ComponentModel.DataAnnotations;
using Warehouse.DataAccess.Entities;

namespace Warehouse.DataAccess.Entities
{
    public class Book : EntityBase
    {
        public int BookCaseId { get; set; }
        public BookCase BookCase { get; set; }
        public List<Author> Authors { get; set; }

        [Required]
        [MaxLength(250)]
        public string Title { get; set; }
        public int Year { get; set; }
    }
}
