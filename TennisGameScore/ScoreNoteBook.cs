using System;
using System.Collections.Generic;

namespace TennisGameScore
{
    public static class ScoreNoteBook
    {
        #region Constuctor
        #endregion     
        #region Properties
        private static Dictionary<string,string> _score ;
        #endregion 
        #region Methods
        public static Dictionary<string,string> SaveScore(TennisPlayer firstPlayer, TennisPlayer secondPlayer)
        {
                _score = new Dictionary<string,string>();
                _score.Add(firstPlayer.Name,firstPlayer.ScoreResult);
                _score.Add(secondPlayer.Name,secondPlayer.ScoreResult);
                return _score;
        }
        #endregion  
    }
}
