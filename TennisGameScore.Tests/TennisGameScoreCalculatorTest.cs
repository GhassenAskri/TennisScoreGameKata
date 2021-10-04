using System;
using Xunit;
using TennisGameScore;
using System.Collections.Generic;

namespace TennisGameScore.Tests
{
    public class TennisGameScoreCalculatorTest
    {
        private readonly string _welcomeMessage =  "Welcome to the tennis score game calculator";
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
            TennisPlayer firstPlayer = new TennisPlayer("Rafeal Nadal");
            TennisPlayer secondPlayer = new TennisPlayer("Roger Federer");
            Dictionary<string,string> gameScore;

            //When
            firstPlayer.HasWinAPoint("love");
            
            //Then
            TennisGameScoreCalculator tennisGameScoreCalculator = new TennisGameScoreCalculator();
            
            gameScore = tennisGameScoreCalculator.CalculateScore(firstPlayer,secondPlayer);
            string firstPlayerScore = gameScore[firstPlayer.Name];
            //Assert
            Assert.True(firstPlayerScore == "love");
        }

        
    }
}
