using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrilaterals
{
    public abstract class Quadrilateral : IQuadrilateral
    {
        public abstract double Area();

        public virtual string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"Perimeter: {Perimeter()}");
            sb.AppendLine($"Area: {Area()}");

            return sb.ToString();
        }

        public abstract int Perimeter();
    }
}
