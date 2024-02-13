using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrilaterals
{
    public class Trapezoid : Quadrilateral
    {
        public Trapezoid(int longBase, int shortBase, int leftLeg, int rightLeg, int height)
        {
            LongBase = longBase;
            ShortBase = shortBase;
            LeftLeg = leftLeg;
            RightLeg = rightLeg;
            Height = height;
        }

        public int LongBase { get; }
        public int ShortBase { get; }
        public int LeftLeg { get; }
        public int RightLeg { get; }
        public int Height { get; }

        public override double Area()
        {
            return (LongBase + ShortBase) * Height / 2;
        }

        public override int Perimeter()
        {
            return (LongBase + ShortBase + LeftLeg + RightLeg);
        }

        public override string GetInfo()
        {
            StringBuilder sb = new();

            sb.AppendLine(base.GetInfo());
            sb.AppendLine($"Short Base: {LongBase}");
            sb.AppendLine($"Long Base: {ShortBase}");
            sb.AppendLine($"Left Leg: {LeftLeg}");
            sb.AppendLine($"Right Leg: {RightLeg}");
            sb.AppendLine($"Height: {Height}");

            return sb.ToString();
        }
    }
}
