using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day5
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Cat> catArmy = new List<Cat>();
            List<Turtle> turtleArmy = new List<Turtle>();

            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                if (rand.NextDouble() >= 0.5)
                {
                    catArmy.Add(new Cat());
                }
                else
                {
                    turtleArmy.Add(new Turtle());
                }
            }

            //code to tell each cat how many cats there are
            //need to run this any time we add a cat
            int totalCats = catArmy.Count;
            foreach (Cat cat in catArmy)
            {
                cat.CatCount = totalCats;
            }
            catArmy[0].WarCry();


            //code to tell how turtles how many turtles there are


            Turtle.WarCry();



        }
    }
}
