using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day5
{
    class Turtle
    {
        //this static variable belongs to the class
        //it is shared between all instances
        //also means you can use variable without creating instance first
        static int turtleCount;
      


        public Turtle()
        {
            turtleCount++;
        }

        //static method belongs to class
        //shared between all instances
        //can use methos without creating any instances
        public static void WarCry()
        {
            Console.WriteLine("we are an army of " + turtleCount + " turtles!!!!!");
        }



    }
}
