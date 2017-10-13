using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day5
{
    class Cat
    {
        private int catCount;
        

        public int CatCount
        {
            get { return this.catCount; }
            set { this.catCount = value; }
        }

        public Cat()
        {
            catCount++;
        }

        public void WarCry()
        {
            Console.WriteLine("we are an army of " + catCount + " cats!!!!!");
        }








    }
}
