using System;
using System.Collections.Generic;
using System.Text;

namespace differed_linq
{
    public class Movie
    {
        public string Name { get; set; }
        int _year;
        public int Year
        {
            get
            {
                Console.WriteLine($"Reading Year{this._year} of Movie {this.Name}");
                return this._year;
            }
            set
            {
                this._year = value;
            }
        }
    }
}
