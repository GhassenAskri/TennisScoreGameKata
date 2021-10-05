using System;
using System.Collections;
using System.Collections.Generic;

namespace TennisGameScore
{
    public class Player{
        #region Properties
        public string Name {get;set;}
        private Score _scoreRecord{get;set;}
        public string Score
        {
            get{
                return _scoreRecord.getTotalScorePoints();
            }
        }
           
        #endregion 
        #region Constructor
        public Player(string name)
        {
            this.Name = name;  
            this._scoreRecord = new Score();        
        }
        #endregion
        public void HasWinTheBall(int numberOfBall){
           this._scoreRecord.AddNewScorePoint(numberOfBall);
        }
        public void HasWinTheGameBall(){
            this._scoreRecord.AddNewScorePoint("gameBall");
        }
    }
}