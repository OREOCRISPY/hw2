using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Box[] myBox = new Box[3];
            myBox[0] = new Box();
            myBox[1] = new Box();
            myBox[1].setBreadth(5);
            myBox[1].setHeight(21);
            myBox[1].setLength(13);
            myBox[2] = new Box();
            myBox[2].setBreadth(31);
            myBox[2].setHeight(52);
            myBox[2].setLength(73);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Volume of {0}:{1}", Enum.GetName(typeof(set), i),myBox[i].getVolume());
            }
        }
    }
    enum set{ 
        Box1, Box2, Box3
    }
}
