using System;

namespace Lab4
{

	public class Point
	{
        private double _x,_y;
        public double x
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public double y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

		public Point ()
		{
            x = y = 0;
		}
        public Point(Point input) {
            x = input.x; y = input.y;
        }
        public Point(double xx, double yy) {
            x = xx; y = yy;
        }
        public override String ToString() {
            return String.Format("({0},{1})",x,y);
        }
	}
}

