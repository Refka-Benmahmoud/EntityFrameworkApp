using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkApp.Model
{
    [Table("persons")]  
    public class Person
    {
        [Column("ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("FirstName")]
        [MaxLength(20),MinLength(2)]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        public int Age { get; set; }

        public ICollection<Address> Address { get; set; }

        public Person()
        {
            Address = new List<Address>();
        }
    }
}
