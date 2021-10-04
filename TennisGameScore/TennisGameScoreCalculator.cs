using System;
using System.Collections.Generic;

namespace TennisGameScore
{
    public class TennisGameScoreCalculator
    {
        #region Constuctor
        #endregion     
        #region Properties
         public string WelcomeMessage { 
            get {
                return "Welcome to the tennis score game calculator";
            }
        }
        #endregion 
        #region Methods
        public Dictionary<string,string> CalculateScore(TennisPlayer firstPlayer, TennisPlayer secondPlayer)
        {
                Dictionary<string,string> gameScore = new Dictionary<string,string>();
                gameScore.Add(firstPlayer.Name,firstPlayer.Score);
                gameScore.Add(secondPlayer.Name,secondPlayer.Score);
                return gameScore;
        }
        #endregion  
    }
}
