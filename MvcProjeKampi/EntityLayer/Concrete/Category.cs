using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(100)]
        public string CategoryName { get; set; }
        [StringLength(1000)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        /* ICollection  Paremetresi bire çok ilişki için kullanılar paremetre  bu paraetre <> arasına yazılan classa ilki kurarak Belirtilen fielde veri gönderir */
        public ICollection<Heading> Headings { get; set; }
        
    }
}
