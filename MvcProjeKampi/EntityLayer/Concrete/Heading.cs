using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public  int HeadingID { get; set; }
        [StringLength(200)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }
    }
}
