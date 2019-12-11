using System;
using System.Collections.Generic;
using System.Text;

namespace TheRover.Interfaces
{
    public interface IRuleEngine
    {
        Coordinates PredictNextStep(Coordinates position,string commands);
    }
}
