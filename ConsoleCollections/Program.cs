using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList();
            items.Add(new Book("Call of the wild", 5.99, "9780451531346"));
            items.Add(new CD("Savoy Brown", 15.99, "Savoy Brown"));
            items.Add(new Item("Humus", 2.99));
            items.Sort();
            ShowShoppingCart(items);
            Console.ReadKey();
        }

        public class  SortItemByPrice : IComparer 
        {

            public int Compare(object x, object y)
            {
                throw new NotImplementedException();
            }
        }

        static void ShowShoppingCart(ArrayList items)
        {
            foreach (Item i in items)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
    class Item : IComparable
    {
        public string Title;
        public double Price;

        public override string ToString()
        {

            return Title + ":" + Price.ToString();
        }
        public Item() { }
        public Item(string _title, double _price) {
            this.Title = _title;
            this.Price = _price;

        }

        public int CompareTo(object obj)
        {
            return this.Title.CompareTo(((Item)obj).Title);
        }
    }
    class Book : Item
    {
        public string ISBN;

        public Book(string _title, double _price, string _isbn)
        {
            this.Title = _title;
            this.Price = _price;
            this.ISBN = _isbn;
        }
    }
    class CD : Item
    {
        public string Artist;

        public CD(string _title, double _price, string _artist)
        {
            this.Title = _title;
            this.Price = _price;
            this.Artist = _artist;
        }
    }
}
