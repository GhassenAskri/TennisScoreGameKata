using System;
using System.Collections;
using System.Collections.Generic;

namespace TennisGameScore
{
    public class TennisPlayer{
        #region Properties
        public string Name {get;set;}
        private ScoreRecord _scoreRecord{get;set;}
        public string Score
        {
            get{
                return _scoreRecord.getTotalScorePoints();
            }
        }
           
        #endregion 
        #region Constructor
        public TennisPlayer(string name)
        {
            this.Name = name;  
            this._scoreRecord = new ScoreRecord();        
        }
        #endregion
        public void HasWinTheBall(int numberOfBall){
           this._scoreRecord.AddNewScorePoint(numberOfBall);
        }
    }
}