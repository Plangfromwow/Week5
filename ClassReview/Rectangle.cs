using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassReview
{
    public class Rectangle
    {
        public decimal length { get; set; }
        public decimal width { get; set; }

        public Rectangle (decimal _length, decimal _width)
        {
            length = _length;
            width = _width;
        }

        public decimal perim()
        {
            return 2*length + 2*width;
        }

        public decimal area()
        {
            return length * width;
        }

        public override string ToString()
        {
            return $"RECTANGLE: Length:{length} Width:{width} Perim: {perim()} Area: {area()}";
        }

    }
}
