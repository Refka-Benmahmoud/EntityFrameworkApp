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
        [MaxLength(1), MinLength(1)]
        public string Sex { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }

        public Person()
        {
            Addresses = new List<Address>();
        }
    }
}
