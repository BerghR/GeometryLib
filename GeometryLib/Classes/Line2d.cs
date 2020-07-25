using System.Collections.Generic;

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
            set { _start = value; }
        }

        public Point2d End
        {
            get { return _end; }
            set { _end = value; }
        }

        public Line2d()
        {
        }

        public Line2d(Point2d start, Point2d end)
        {
            _start = start;
            _end = end;
        }
    }

    public class LineSet
    {
        private Dictionary<int, Line2d> _lines;

    }
}
