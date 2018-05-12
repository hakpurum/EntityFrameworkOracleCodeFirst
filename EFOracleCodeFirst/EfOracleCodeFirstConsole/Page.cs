using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfOracleCodeFirstConsole
{
    [Table("Page")]
    public class Page
    {
        [Column(TypeName = "number")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(100)]
        public string Deneme { get; set; }

        [StringLength(100)]
        public string test { get; set; }

        [StringLength(100)]
        public string test4 { get; set; }

        [StringLength(100)]
        public string Test5 { get; set; }

        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
