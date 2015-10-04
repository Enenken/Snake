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
          
            //p1.Draw();

            Point p2 = new Point(4,5,'*');

            //p2.Draw();

            Point p3 = new Point(10, 10, '%');
            Point p4 = new Point(9, 1, '&');

            List<int> spisok = new List<int>();
            spisok.Add(9);
            spisok.Add(1);
            spisok.Add(1);

            foreach(int i in spisok)
            {
                Console.WriteLine(i);

            }

            List<Point> tochki = new List<Point>();
            tochki.Add(p1);
            tochki.Add(p2);
            tochki.Add(p3);
            tochki.Add(p4);
            foreach (Point i in tochki)
            {
                i.Draw();

            }

            Console.ReadLine();
        }
       
    }
}
