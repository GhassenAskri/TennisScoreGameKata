using System;

namespace TennisGameScore
{
    public class TennisGameScoreCalculator
    {
        private readonly string _welcomeMessage =  "Wellcome to the tennis game";

        public TennisGameScoreCalculator()
        {
            
        }
        public string BeginGame()
        {
               return _welcomeMessage;
        }
        
    }
}
