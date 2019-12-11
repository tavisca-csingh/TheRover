using System;
using System.Collections.Generic;
using System.Text;

namespace TheRover.Translator
{
    public static class FinalPositionTranslator
    {
        public static string GetCoordinates(Coordinates coordinates)
        {
            string result = coordinates.Xcoordinates.ToString() + "," + coordinates.Ycoordinates.ToString()+","+coordinates.Direction;
            return result;
        }
    }
}
