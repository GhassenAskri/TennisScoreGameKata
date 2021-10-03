using System;

namespace TennisGameScore
{
    public class TennisGameScoreCalculator
    {
        private readonly string _welcomeMessage =  "Welcome to the tennis game";

        public TennisGameScoreCalculator()
        {
            
        }
        public string BeginGame()
        {
               return _welcomeMessage;
        }
        
    }
}
