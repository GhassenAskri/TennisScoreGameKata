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
        private Dictionary<object,string> _scoreDictionaryRewards = new Dictionary<object, string>(){
            {0,"love"},
            {1,"fifteen"},
            {2,"thirteen"},
            {3,"fourteen"},
            {"gameBall","winner"},
        };
        public ICollection<string> ScoreRecordPoints { get; set;}
        
        public void AddNewScorePoint(object numberOfTheBall)
        {
            this.ScoreRecordPoints.Add(_scoreDictionaryRewards[numberOfTheBall]);
        
        }
        public string getTotalScorePoints()
        {
            string _delimiter = " ";
            return String.Join(_delimiter,ScoreRecordPoints);
        }
    }

   
}