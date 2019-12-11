using System;
using System.Collections.Generic;
using System.Text;

namespace TheRover.Translator
{
    public static class IntialPositionsTranslator
    {
        public static Coordinates GetCoordinates(string position)
        {
            Coordinates coordinates = new Coordinates();

            char[] spearator = { ',', ',' };
            String[] strlist = position.Split(spearator,
               StringSplitOptions.RemoveEmptyEntries);

            coordinates.Xcoordinates = Convert.ToInt32(strlist[0]);
            coordinates.Ycoordinates = Convert.ToInt32(strlist[1]);
            coordinates.Direction = strlist[2];

            return coordinates;
        }
    }
}
