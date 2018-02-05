using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* List<Tafel> tafels = new List<Tafel>();
             var rndGen = new Random();

             for(var i = 0; i < 10; i++)
             {
                 var w = rndGen.Next(50, 200);
                 var l = rndGen.Next(50, 200);
                 tafels.Add(new Tafel(w, l));
             }

             foreach(var t in tafels)
             {
                 t.ShowData();
             }
             */
            Tafel[] tafels = new Tafel[10];
            var rndGen = new Random();
            for (var i = 0; i < 10; i++)
            {
                var w = rndGen.Next(50, 200);
                var l = rndGen.Next(50, 200);
                var t = new Tafel(w, l);
                tafels[i] = t;
            }

            foreach (var t in tafels)
            {
              
                t.ShowData();
            }

        }

    }
}
