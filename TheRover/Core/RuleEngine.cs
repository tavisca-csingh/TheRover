using System;
using System.Collections.Generic;
using System.Text;
using TheRover.Interfaces;

namespace TheRover
{
    public class RuleEngine : IRuleEngine
    {
        public Coordinates PredictNextStep(Coordinates position, string commands)
        {
            switch (position.Direction)
            {
                case "E":
                    if (commands =="M")
                        position.Xcoordinates += 1;
                    if (commands == "L")
                        position.Direction = "N";
                    if (commands == "R")
                        position.Direction = "S";
                    return position;
                case "W":
                    if (commands == "M")
                        position.Xcoordinates += -1;
                    if (commands == "L")
                        position.Direction = "S";
                    if (commands == "R")
                        position.Direction = "N";
                    return position;
                case "N":
                    if (commands == "M")
                        position.Ycoordinates += 1;
                    if (commands == "L")
                        position.Direction = "W";
                    if (commands == "R")
                        position.Direction = "E";
                    return position;
                case "S":
                    if (commands == "M")
                        position.Ycoordinates += -1;
                    if (commands == "L")
                        position.Direction = "E";
                    if (commands == "R")
                        position.Direction = "N";
                    return position;
                default:
                    return null;
            }
        }
    }
}
