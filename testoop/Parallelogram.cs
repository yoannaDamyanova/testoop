using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrilaterals
{
    public class Parallelogram : Quadrilateral
    {
        public Parallelogram(int sideA, int sideB, int height)
        {
            SideA = sideA;
            SideB = sideB;
            Height = height;
        }

        public int SideA { get;}
        public int SideB { get;}
        public int Height { get;}

        public override double Area()
        {
            return SideA * Height;
        }

        public override int Perimeter()
        {
            return 2 * (SideA + SideB);
        }

        public override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.GetInfo());
            sb.AppendLine($"Side A: {SideA}");
            sb.AppendLine($"Side B: {SideB}");
            sb.AppendLine($"Height: {Height}");
            return sb.ToString();
        }
    }
}
