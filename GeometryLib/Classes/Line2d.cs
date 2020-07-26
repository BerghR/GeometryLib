using System;

namespace GeometryLib.Classes
{
    public class Line2d
    {
        //List of fucntionality to add
        //TODO:
        //1. Implement line angle calculation on property change

        private Point2d _start; //start point
        private Point2d _end; //end point
        private double _angle; //Angle of line

        public Point2d Start
        {
            get { return _start; }
            set
            {
                _start = value;
                CalculateAngle();
            }
        }

        public Point2d End
        {
            get { return _end; }
            set
            {
                _end = value;
                CalculateAngle();
            }

        }

        public double Angle
        {
            get => _angle;
        }

        public Line2d()
        {
        }

        public Line2d(Point2d start, Point2d end)
        {
            _start = start;
            _end = end;
            CalculateAngle();
        }

        public Point2d IntersectWith(Line2d line, double tolerance = 0.0001)
        {
            throw new NotImplementedException();

        }


        public bool IsOnLine(Point2d point)
        {
            throw new NotImplementedException();
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(_end.X - _start.X, 2) + Math.Pow(_end.Y - _start.Y, 2));
        }

        private void CalculateAngle()
        {
            if (!double.IsNaN(_start.X) && !double.IsNaN(_start.Y) && !double.IsNaN(_end.X) && !double.IsNaN(_end.Y))
            {
                var inRadians = Math.Atan2(_end.X - _start.X, End.Y - _start.Y);

                if (inRadians < 0)
                {
                    inRadians = (2 * Math.PI + inRadians);
                }

                _angle = (inRadians * 360 / (2 * Math.PI));

            }
        }

    }
}
