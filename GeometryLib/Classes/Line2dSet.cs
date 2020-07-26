using System;
using System.Collections.Generic;

namespace GeometryLib.Classes
{
    public class Line2dSet
    {
        private List<Line2d> _lines;
        private int _lineCount;

        public int Count
        {
            get => _lineCount;
        }

        public Line2dSet()
        {
            _lines = new List<Line2d>();
            _lineCount = 0;
        }

        public void Add(Line2d line)
        {
            _lines.Add(line);
            _lineCount++;
        }

        public void Remove(Line2d line)
        {
            if (_lines.Contains(line))
            {
                _lines.Remove(line);
                _lineCount--;
            }
        }

        public void RemoveAt(int index)
        {
            if (index > _lineCount)
            {
                throw new IndexOutOfRangeException("index out of range");
            }
            else
            {
                _lines.RemoveAt(index);
                _lineCount--;
            }
        }
    }
}