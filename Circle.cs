using System;

namespace Lab4
{
	public class Circle
	{
        private Point _center;
        private double _radius;
        public Point center 
        {
            get {
                return _center;
            }
            set {
                _center = value;
            }
        }
        public double radius
        {
            get { return _radius; }
            set { if (value >= 0)_radius = value; else _radius = 1; }
        }
		public Circle ()
		{
            center = new Point();
            radius = 1;
		}
        public Circle(double rr) {
            center = new Point();
            radius = rr;
        }
        public Circle(double xx, double yy, double rr) {
            center = new Point(xx,yy);
            radius = rr;
        }
        public Circle(Circle a) {
            center = a.center;
            radius = a.radius;
        }
        public void setCircle(double xx, double yy, double rr)
        {
            center = new Point(xx, yy);
            radius = rr;
        }
        public virtual double getArea()
        { 
            //area of circle  PI.R^2 
            return (Math.PI) * radius * radius;
        }
        public override String ToString()
        {
            return String.Format("[Circle: center{0}, radius={1}, area={2}]", center, radius, getArea());
            //[Circle: center(0,0), radius=1, area=3.14159265358979]
        }
	}
}

