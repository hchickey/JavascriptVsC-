using System;
using System.Collections.Generic;
using System.Linq;

namespace DinnerParty
{
    class Program
    {
        static void Main(string[] args)
        {

            Guest marilyn = new Guest()
            {
                Name = "Marilyn Monroe",
                Occupation = "entertainer",
                Bio = "(1926 - 1962) American actress, singer, model"
            };

            Guest abraham = new Guest()
            {
                Name = "Abraham Lincoln",
                Occupation = "politician",
                Bio = "(1809 - 1865) US President during American civil war"
            };

            Guest martin = new Guest()
            {
                Name = "Martin Luther King",
                Occupation = "activist",
                Bio = "(1929 - 1968) American civil rights campaigner"
            };

            Guest rosa = new Guest()
            {
                Name = "Rosa Parks",
                Occupation = "activist",
                Bio = "(1913 - 2005) American civil rights activist"
            };

            Guest peter = new Guest()
            {
                Name = "Peter Sellers",
                Occupation = "entertainer",
                Bio = "(1925 - 1980) British actor and comedian"
            };

            Guest alan = new Guest()
            {
                Name = "Alan Turing",
                Occupation = "computer scientist",
                Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
            };

            Guest admiral = new Guest()
            {
                Name = "Admirla Grace Hopper",
                Occupation = "computer scientist",
                Bio = "(1906 - 1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
            };

            Guest indira = new Guest()
            {
                Name = "Indira Gandhi",
                Occupation = "politician",
                Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977"
            };

            List<Guest> guests = new List<Guest>();
            guests.Add(marilyn);
            guests.Add(abraham);
            guests.Add(martin);
            guests.Add(rosa);
            guests.Add(peter);
            guests.Add(alan);
            guests.Add(admiral);
            guests.Add(indira);

            List<Guest> table1 = new List<Guest>();
            List<Guest> table2 = new List<Guest>();

            foreach (Guest guest in guests)
            {
                List<string> table1Occupations = new List<string>(table1.Select(g => g.Occupation));
                if (table1Occupations.Contains(guest.Occupation))
                {
                    table2.Add(guest);
                }
                else
                {
                    table1.Add(guest);
                }
            }

            Console.WriteLine("Table 1: ");
            foreach (Guest guest in table1)
            {
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
            }

            Console.WriteLine("Table 2: ");
            foreach (Guest guest in table2)
            {
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
            }

        }

        public class Guest
        {
            public string Name { get; set; }
            public string Occupation { get; set; }
            public string Bio { get; set; }
        }



    }

}
