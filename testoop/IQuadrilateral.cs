using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrilaterals
{
    interface IQuadrilateral
    {
        int Perimeter();
        double Area();
        string GetInfo();
    }
}
