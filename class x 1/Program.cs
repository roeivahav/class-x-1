using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_x_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your ball details:");
            Ball my_new_ball = new Ball();
            Console.WriteLine("size?");
            my_new_ball.set_size(int.Parse(Console.ReadLine()));
            Console.WriteLine("color?");
            my_new_ball.set_color(Console.ReadLine());
            Console.WriteLine("type?");
            my_new_ball.set_type(Console.ReadLine());
            Console.WriteLine("fabric?");
            my_new_ball.set_fabric(Console.ReadLine());







        }
    }
}
