using System;
using Xunit;
using TennisGameScore;
using System.Collections.Generic;

namespace TennisGameScore.Tests
{
    public class TennisGameScoreCalculatorTest
    {
        #region Setup
        private readonly string _welcomeMessage =  "Welcome to the tennis score game calculator";
        private  TennisPlayer _firstPlayer = new TennisPlayer("Rafeal Nadal");
        private TennisPlayer _secondPlayer = new TennisPlayer("Roger Federer");
        private Dictionary<string,string> _gameScore;
        private TennisGameScoreCalculator _tennisGameScoreCalculator; 
        #endregion

        #region Tests
        [Fact]
        public void When_The_Tennis_Score_Game_Calculator_Called_Welcome_Message_Should_Be_Returned()
        {
            TennisGameScoreCalculator tennisGameScoreCalculator = new TennisGameScoreCalculator();
            string tennisGameScoreCalculatorWelcomeMessage = tennisGameScoreCalculator.WelcomeMessage;
            Assert.Equal(_welcomeMessage,tennisGameScoreCalculatorWelcomeMessage);
        }
        [Fact]
        public void When_The_First_Player_Win_The_First_Ball()
        {
            //Given
            _firstPlayer.HasWinTheBall(0);
            _secondPlayer.HasLooseTheBall(0);
            //When
            _tennisGameScoreCalculator = new TennisGameScoreCalculator();
            _gameScore = _tennisGameScoreCalculator.CalculateScore(_firstPlayer,_secondPlayer);
            string firstPlayerScore = _gameScore[_firstPlayer.Name]; 
            string secondPlayerScore = _gameScore[_secondPlayer.Name]; 
            //Assert
            Assert.True(firstPlayerScore == "love");
            Assert.True(secondPlayerScore == "-");
        }
        #endregion
    }
}
