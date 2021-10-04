using System;
namespace TennisGameScore
{
    public class TennisPlayer{
        #region Properties
        public string Name {get;set;}
        public Score Score {get;set;}
        #endregion 
        #region Constructor
        public TennisPlayer(string name)
        {
            this.Name = name;  
            this.Score = new Score();        
        }
        public void HasWinTheBall(int numberOfBall){
        if(numberOfBall == 0)
           this.Score.AddNewScore("love");
        if(numberOfBall == 1)
            this.Score.AddNewScore("fifteen");
        }
        public void HasLooseTheBall(int numberOfBall){
           this.Score.AddNewScore("-");
        }
        #endregion
    }
}