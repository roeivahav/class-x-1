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
            //Ball my_new_ball = new Ball();
            //Console.WriteLine("size?");
            //my_new_ball.set_size(int.Parse(Console.ReadLine()));
            //Console.WriteLine("color?");
            //my_new_ball.set_color(Console.ReadLine());
            //Console.WriteLine("type?");
            //my_new_ball.set_type(Console.ReadLine());
            //Console.WriteLine("fabric?");
            //my_new_ball.set_fabric(Console.ReadLine());

            int my_ball_size = int.Parse(Console.ReadLine());
            string my_ball_type = Console.ReadLine();
            string my_ball_color = Console.ReadLine();
            string my_ball_fabric = Console.ReadLine();

            Ball my_new_ball = new Ball(my_ball_size, my_ball_color, my_ball_type, my_ball_fabric);

            Console.WriteLine("This is my ball details: {0}, {1}, {2}, {3}", my_new_ball.get_size(), my_new_ball.get_color(),my_new_ball.get_type(),my_new_ball.get_fabric());
           



        }
    }
}
