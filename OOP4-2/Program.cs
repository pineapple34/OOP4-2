using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Год - " + book.Year);
                Console.WriteLine("Новое значение - ");
                int.TryParse(Console.ReadLine(), out int newYear);
                book.Year = newYear;
            }
        }
    }

    class Book
    {
        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value >= 1940 && value <= 2020) year = value;
            }
        }
        public Book()
        {
            this.year = 1940;
        }
    }
}
