using System;
using System.Collections.Generic;
using System.Text;

namespace TheRover.Interfaces
{
    public interface IPositionDetector
    {
        string GetFinalPosition(string position,string commands);
    }
}
