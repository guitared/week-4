using System;

namespace Lab4
{
	public class Cylinder : Circle // Extends Circle Class
	{
        //center : Point            <= Don't forget to initialize it when creates object !!!!
        //radius : double

        private double _height;
        public double height 
        {
            get 
            {
                return _height;
            } 
            set
            {
                if(value >= 0)
                    _height = value;
                else _height = 1;
            } 
        }
		public Cylinder ()
		{
            center = new Point();
            radius = 1;
            height = 1;
		}
        public Cylinder(double rr,double hh)
        {
            center = new Point();
            radius = rr;
            height = hh;
        }
        public Cylinder(double xx, double yy, double rr, double hh) {
            center = new Point(xx,yy);
            radius = rr;
            height = hh;
        }
        public Cylinder(Cylinder a){
            center = a.center;
            radius = a.radius;
            height = a.height;
        }
        public Cylinder(Circle a)
        {
            center = a.center;
            radius = a.radius;
            height = 1;
        }
        public override double getArea()
        {
            //area of cycle  2(PI.R^2) + cylinder surface (2PI.R.Height)  
//            return 2*((Math.PI) * radius * radius)+(2*Math.PI*radius*height);
            return 2 * Math.PI * ((radius * radius) + (radius * height));
        }
        public virtual double getVolume() { 
            //PI.R.R.H
            return Math.PI * radius * radius * height;
        }
        public override string ToString()
        {
           // return base.ToString();
            //[Cylinder: center(1,1), radius=3, height=4, surface=131.946891450771, volume=113.097335529233]
            return String.Format("[Cylinder: center{0}, radius={1}, height={2}, surface={3}, volume={4}]", center, radius, height, getArea(), getVolume());
        }
	}
}

