using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
          
           // p1.Draw();

            Point p2 = new Point(4,5,'*');

            // p2.Draw();
            p2 = p1;
            Console.WriteLine(p1.x + " " + p1.y);
            Console.WriteLine(p2.x + " " + p2.y);
            p1.x = 10;
            Console.WriteLine(p2.x + " " + p2.y);
            Console.ReadLine();
        }
       
    }
}
