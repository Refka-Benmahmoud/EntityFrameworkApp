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
                    City = "Marseille",
                    CodeP = "13015"
                };
                var person = new Person()
                {
                    FirstName = "Ernest",
                    LastName = "Jacques",
                    Age = 45
                };
                person.Address.Add(address);

                // on persiste la personne
                model.Person.Add(person);
                model.SaveChanges();
                // on recupere le contenu de l’entity Personne
                var persoQuery = from perso in model.Person
                                 select perso;
                // on affiche la personne ainsi que sa premiere adresse
                foreach (var elt in persoQuery)
                    Console.WriteLine($"Bonjour {elt.LastName} {elt.FirstName} de { elt.Address.First<Address>().City} ");
            }
            Console.ReadKey();

        }
    }
}

