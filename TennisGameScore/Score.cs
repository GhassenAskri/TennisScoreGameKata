using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TennisGameScore
{
    public class Score
    {
        #region Constructor
        public Score()
        {
            this.ScoreRecordPoints = new Collection<string>();
        }
        #endregion
        #region Properties
        private Dictionary<object,string> _scoreDictionaryRewards = new Dictionary<object, string>(){
            {1,"love"},
            {2,"fifteen"},
            {3,"thirteen"},
            {4,"fourteen"},
            {5,"advantage"},
            {"gameBall","winner"},
        };
        public ICollection<string> ScoreRecordPoints { get; set;}
        #endregion
        #region Methods 
        public void AddNewScorePoint(object _numberOfSucceffulBalls)
        {

            this.ScoreRecordPoints.Add(_scoreDictionaryRewards[_numberOfSucceffulBalls]);
        
        }
        public string getTotalScorePoints()
        {
            string _delimiter = " ";
            return String.Join(_delimiter,ScoreRecordPoints);
        }
    }
    #endregion
   
}