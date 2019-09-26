using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_program
{
    class Program
    {
        public void swap(ref int x, ref int y) {
            int temp = x;
            x = y;
            y = temp;

        }

        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Program app = new Program();
            app.swap(ref x, ref y);
            Console.WriteLine("x = {0}, y = {1}", x, y);
            Console.Read();
        }
    }
}
