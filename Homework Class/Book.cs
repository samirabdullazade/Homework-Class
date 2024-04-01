using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Class
{
    public class Book
    {
        private string title;
        private string author;
        private string publisher;
        private int availableCopies;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public int AvailableCopies
        {
            get { return availableCopies; }
            set { availableCopies = value; }
        }
        public Book(string title, string author, string publisher, int availableCopies)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            AvailableCopies = availableCopies;
        }
        public void IncreaseCopies(int quantity)
        {
            if (quantity < 0)
            {
                Console.WriteLine("Düzgün nüsxə sayı daxil edin.");
            }
            AvailableCopies += quantity;
        }
        public void DecreaseCopies(int quantity)
        {
            if (quantity < 0)
            {
                Console.WriteLine("Düzgün nüsxə sayı daxil edin.");
            }
            if (AvailableCopies < quantity)
            {
                Console.WriteLine("Düzgün nüsxə sayı daxil edin.");
            }
            AvailableCopies -= quantity;
        }
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Available Copies: {AvailableCopies}");
        }
    }
}