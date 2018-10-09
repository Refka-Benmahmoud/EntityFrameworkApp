using EntityFrameworkApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var model = new Model1())
            {
                var address = new Address
                {
                    StreetNumber = 32,
                    City = "Gabes",
                    CodeP = "6000"
                };
                var person = new Person()
                {
                    FirstName = "Refka",
                    LastName = "Benmahmoud",
                    Age = 26
                };
               person.Addresses.Add(address);

                // we persist the person
              //  model.Person.Add(person);
               // model.SaveChanges();

                // we get the content of entity Person
                var persoQuery = from perso in model.Person    
                                 select perso;
                // we display the person and his first address
                foreach (var elt in persoQuery)
                   // Console.WriteLine($"Hello {elt.LastName} {elt.FirstName} from { elt.Addresses.First<Address>().City} ");
                Console.WriteLine($"Hello {elt.LastName} {elt.FirstName} ");



                // To edit
                var personToBeDeleted = (from p in model.Person
                                         where p.LastName.Equals("Benmahmoud")
                                         select p).First();
                personToBeDeleted.FirstName = "Refka";
                model.SaveChanges();

                //To delete
               // Person p2 = model.Person.First(perso => perso.
                //Id == 1);
                //model.Person.Remove(p2);
                //model.SaveChanges();
            }
            Console.ReadKey();

        }
    }
}

