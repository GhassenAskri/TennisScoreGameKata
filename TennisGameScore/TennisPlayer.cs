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
        public void HasWinAPoint(string nameOfThePoint){
            this.Score = nameOfThePoint;
        }
        #endregion
    }
}