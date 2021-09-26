using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1222.Helpers
{
    class POINT
    {
        private double x;
        private double y;

        public double X { get { return x; } }
        public double Y { get { return y; } }

        public POINT(double x, double y) {
            this.x = x;
            this.y = y;
        }
    }
}
