using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Models
{
    class Product
    {
        private LinkedList<string> parts;
        public Product()
        {
            parts = new LinkedList<string>();
        }

        public void Add(string part)
        {
            parts.AddLast(part);
        }

        public void Show()
        {
            foreach(string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
