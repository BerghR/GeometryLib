using System;

namespace GeometryLib.Classes
{
    public class Line2d
    {
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

        /// <summary>
        /// Calculate the intersection between two lines.
        /// </summary>
        /// <param name="line">Second line to check</param>
        /// <param name="actual">Actual intersect only otherwise projected intersection would be returned.</param>
        /// <returns></returns>
        public Point2d IntersectWith(Line2d line, bool actual = true)
        {
            double a1 = _end.Y - _start.Y;
            double b1 = _start.X - _end.X;
            double c1 = a1 * (_start.X) + b1 * (_start.Y);

            double a2 = line.End.Y - line.Start.Y;
            double b2 = line.Start.X - line.End.X;
            double c2 = a2 * (line.Start.X) + b2 * (line.Start.Y);

            double determinant = a1 * b2 - a2 * b1;

            if (determinant == 0)
            {
                return new Point2d(double.NaN, double.NaN);
            }
            else
            {
                double x = (b2 * c1 - b1 * c2) / determinant;
                double y = (a1 * c2 - a2 * c1) / determinant;
                var intersection = new Point2d(x, y);

                if (actual)
                {
                    if (!IsPointOnLine(intersection))
                    {
                        intersection.X = double.NaN;
                        intersection.Y = double.NaN;
                    }
                }
                return intersection;
            }

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

        public bool IsPointOnLine(Point2d point)
        {
            //y = ax + b
            double a = (_start.Y - _end.Y) / (_start.X = _end.X);
            double b = _start.Y - (a * _start.X);

            var resultY = a * point.X + b;

            if (
                resultY == point.Y &&
                !((Start.X <= point.X && point.X <= End.X) &&
                  (Start.Y <= point.Y && point.Y <= End.Y)
                  ||
                  (End.X <= point.X && point.X <= Start.X) &&
                  (End.Y <= point.Y && point.Y <= Start.Y))
                )
            {
                return true;

            }

            return false;

        }

    }
}
