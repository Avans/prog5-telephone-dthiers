using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.Lib;
using TelephoneBook.Lib.Models;

namespace TelephoneBook.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PhoneBook book = new PhoneBook();

            var sortLastName = book.SortByLastName();

            book.PrintList(sortLastName);

            book.PrintList(book.LastNameGreaterThan(9));

            book.PrintList(book.LastNameGreaterThan(10));

            Console.ReadLine();
        }
    }
}
