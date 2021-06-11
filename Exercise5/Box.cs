using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Box
    {
        private double length = 10;
        private double breadth = 20;
        private double height = 30;
        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }


    }
}
