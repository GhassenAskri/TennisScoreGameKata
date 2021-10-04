using System;
using Xunit;
using TennisGameScore;
using System.Collections.Generic;

namespace TennisGameScore.Tests
{
    public class TennisGameScoreCalculatorTest
    {
        #region Setup
        private  TennisPlayer _firstPlayer = new TennisPlayer("Rafeal Nadal");
        private TennisPlayer _secondPlayer = new TennisPlayer("Roger Federer"); 
        private Dictionary<string,string> _scoreNoteBook;    
    
        #endregion

        #region Tests
        [Fact]
        public void When_The_First_Player_Win_The_First_Ball()
        {
            //Given
            _firstPlayer.HasWinTheBall(0);
            _secondPlayer.HasLooseTheBall(0);
            //When
            _scoreNoteBook = ScoreNoteBook.SaveScore(_firstPlayer,_secondPlayer);       
            string firstPlayerScore = _scoreNoteBook[_firstPlayer.Name]; 
            string secondPlayerScore = _scoreNoteBook[_secondPlayer.Name]; 
            //Assert
            Assert.True(firstPlayerScore == "love");
            Assert.True(secondPlayerScore == "-");
        }
        #endregion
    }
}
