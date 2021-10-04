using System;
namespace TennisGameScore
{
    public class TennisPlayer{
        #region Properties
        public string Name {get;set;}
        public string Score {get;set;}
        #endregion 
        #region Constructor
        public TennisPlayer(string name)
        {
            this.Name = name;           
        }
        public void HasWinTheBall(int numberOfBall){
           this.Score = "love";
        }
        public void HasLooseTheBall(int numberOfBall){
           this.Score = "-";
        }
        #endregion
    }
}