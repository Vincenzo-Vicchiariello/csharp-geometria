using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class myRectangle
    {
        public int rectangleBase;
        public int rectangleHeight;
        public int rectangleArea;
        public int rectanglePerimeter;
        public myRectangle(int rectangleBase, int rectangleHeight)
        {
            this.rectangleBase = rectangleBase;
            this.rectangleHeight = rectangleHeight;
        }


    
        public int AreaCalc (int x, int y)
        {
            rectangleArea = x * y;
            return rectangleArea;

        }

        public int PerimeterCalc (int x, int y) {
            rectanglePerimeter = x * 2 + y * 2;
            return rectanglePerimeter;
        }


    }
}



 
