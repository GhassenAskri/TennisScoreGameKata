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
            this.scoreSuit = new Collection<string>();
        }
        public ICollection<string> scoreSuit { get; set;}
        private string _delimiter = " ";
        public void AddNewScore(string score)
        {
            this.scoreSuit.Add(score);
        
        }
        public string FormatScore()
        {
            return String.Join(_delimiter,scoreSuit);
        }
    }

   
}