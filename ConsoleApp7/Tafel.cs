using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    class Tafel
    {
           private int Width;
           private int Length;

        public Tafel(int Width, int Length)
        {
            this.Width = Width;
            this.Length = Length;
        
        }

        public void ShowData()
        {
            Console.WriteLine("De breedte van deze tafel is {0} cm.", Width);
            Console.WriteLine("De lengte van deze tafel is {0} cm lang", Length);
            Console.WriteLine("");
        }
    }
}
