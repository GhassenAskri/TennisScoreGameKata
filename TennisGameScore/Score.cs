using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TennisGameScore
{
    public class Score
    {
        public Score()
        {
            this.ScoreRecordPoints = new Collection<string>();
        }
        private string [] _scoreCollectionNames = {"love","fifteen","thirteen","fourteen"};
        public ICollection<string> ScoreRecordPoints { get; set;}
        
        public void AddNewScorePoint(int numberOfTheBall)
        {
            this.ScoreRecordPoints.Add(_scoreCollectionNames[numberOfTheBall]);
        
        }
        public string getTotalScorePoints()
        {
            string _delimiter = " ";
            return String.Join(_delimiter,ScoreRecordPoints);
        }
    }

   
}