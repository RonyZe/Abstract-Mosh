using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            //            var shape = new Shape();

            var circle=new Circle();
            circle.Draw();

            var rect=new Rectangle();
            rect.Draw();
            Console.ReadLine();
        }
    }


}
