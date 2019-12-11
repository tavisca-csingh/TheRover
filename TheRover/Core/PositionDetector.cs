using System;
using System.Collections.Generic;
using System.Text;
using TheRover.Interfaces;
using TheRover.Translator;

namespace TheRover
{
    public class PositionDetector : IPositionDetector
    {
        public string GetFinalPosition(string position,string commands)
        {
            RuleEngine ruleEngine = new RuleEngine();
            var positions=IntialPositionsTranslator.GetCoordinates(position);
            foreach (var item in commands)
            {
                var result = ruleEngine.PredictNextStep(positions,item.ToString());
                positions = result;
            }
            return FinalPositionTranslator.GetCoordinates(positions);
        }
    }
}
