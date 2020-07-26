namespace GeometryLib.Classes
{
    public class Point2d
    {
        private double _x;
        private double _y;

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public Point2d() : this(double.NaN, double.NaN)
        {
        }

        public Point2d(double x, double y)
        {
            _x = x;
            _y = y;
        }
    }
}
