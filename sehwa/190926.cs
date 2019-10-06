using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice4_1
{
    class Program
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
            static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Console.WriteLine("X={0},Y={1}", x, y);
            Program app = new Program();
            app.swap(ref x, ref y);
            Console.WriteLine("X={0},Y={1}", x, y);
        }
    }
}
