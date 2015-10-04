using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            


            HorizontalLine Gline1 = new HorizontalLine(0,78,0,'*');
            VertikalLine Vline1 = new VertikalLine(0, 24,0, '*');
            VertikalLine Vline2 = new VertikalLine(0, 24, 78, '*');
            HorizontalLine Gline2 = new HorizontalLine(0,78, 24, '*');
            Gline1.Draw();
            Gline2.Draw();
            Vline1.Draw();
            Vline2.Draw();
            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            

        }
       
    }
}
