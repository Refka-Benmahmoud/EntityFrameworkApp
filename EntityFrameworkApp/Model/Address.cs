using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkApp.Model
{
   public class Address
    {
        [Key]
        [Column(Order =1)]
        public int StreetNumber { get; set; }
        [Key]
        [Column(Order =2)]
        public string City { get; set; }              
        [Key]
        [Column(Order =3)]
        public string CodeP { get; set; }
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        //can be here too :  [ForeignKey("Person")]
        public Person Person { get; set; }
    }
}
