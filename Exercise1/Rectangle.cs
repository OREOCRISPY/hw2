using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Rectangle
    {
        double length = 1;
        double width = 1;
        public void GetData()
        {
        again:
            Console.WriteLine("enter length:");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter width:");
            width = Convert.ToInt32(Console.ReadLine());
            if (length < 0 || length > 20 || width < 0 || width > 20)
            {
                Console.WriteLine("please enter length and width between 0 and 20");
                goto again;
            }
        }
        public double GetArea()
        {
            return length * width;
        }
        public double GetPerimeter()
        {
            return 2 * (length + width);
        }
        public void Display() {
            Console.WriteLine("Length:{0}",length);
            Console.WriteLine("Width:{0}", width);
            Console.WriteLine("Area:{0}", GetArea());
            Console.WriteLine("Perimeter:{0}", GetPerimeter());
        }
    }

}

