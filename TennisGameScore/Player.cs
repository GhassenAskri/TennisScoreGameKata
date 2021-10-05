using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace TennisGameScore
{
    public class Player{
        #region Properties
        private Score _scoreRecord{get;set;}
        private int _numberOfSucceffulBalls = 0;
        public string Name {get;set;}
        
        
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
            _numberOfSucceffulBalls ++ ;
           this._scoreRecord.AddNewScorePoint(_numberOfSucceffulBalls);
        }
        public void HasWinTheGameBall(){
            this._scoreRecord.AddNewScorePoint("gameBall");
        }
    }
}