using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class Robot
    {
        
        private int _angle;
        private int _distanceCovered;

        public int Angle { get { return _angle; } }
        public int Distance { get { return _distanceCovered; } }

        public Robot(int angle, int distance)
        {
            this._angle = angle;
            this._distanceCovered = distance;
        }

        public void MoveForward(int distance)
        {
            _distanceCovered += distance;
        }

        public void MoveBackward(int distance)
        {
            _distanceCovered -= distance;
        }
    }
}
