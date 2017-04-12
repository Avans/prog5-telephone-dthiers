using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.Lib.Models;

namespace TelephoneBook.Lib
{
    public class PhoneBook
    {
        private List<Person> book;

        private int PersonCount
        {
            get
            {
                return this.book.Count;
            }
        }
        public PhoneBook()
        {
            this.book = new List<Person>();

            for (int i = 1; i <= 10; i++)
            {
                this.book.Add(new Person("Firstname " + (i * i), "Lastname" + (i * i)));
            }
        }

        // Return phonebook sorted by lastname
        public List<Person> SortByLastName()
        {
            Console.WriteLine("##############################\n==> Sorting on lastname\n");
            return this.book.OrderBy(p => p.LastName).ToList();
        }

        // Return list of people that start with letter
        public List<Person> StartsWithLetter(string letter)
        {
            Console.WriteLine("##############################\n==> People that start with letter " + letter + "\n");
            return this.book.Where(p => p.FirstName.StartsWith(letter)).ToList();
        }

        // Return list of people with lastName greater than length
        public List<Person> LastNameGreaterThan(int length)
        {
            Console.WriteLine("##############################\n==> Lastnames with a length greater than " + length + "\n");
            return this.book.Where(p => p.LastName.Length > length).ToList();
        }

        // Return list of people sorted descending by length of lastName
        public List<Person> SortByLengthOfLastNameAscending()
        {
            Console.WriteLine("##############################\n==> Sorting on lastname's length\n");
            return this.book.OrderBy(p => p.LastName.Length).ToList();
        }

        // Print list
        public void PrintList(List<Person> list)
        {
            list.ForEach(p => Console.WriteLine(p.FullName + " - " + p.TelephoneNumber));

            Console.WriteLine("##############################\n");
        }
    }
}
