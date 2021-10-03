using System;
using Xunit;
using TennisGameScore;

namespace TennisGameScore.Tests
{
    public class TennisGameScoreCalculatorTest
    {
        private readonly string _welcomeMessage =  "Welcome to the tennis game";
        [Fact]
        public void When_The_Tennis_Score_Game_Begin_Welcome_Message_Should_Be_Returned()
        {
            TennisGameScoreCalculator tennisGameScoreCalculator = new TennisGameScoreCalculator();
            string tennisGameScoreCalculatorWelcomeMessage = tennisGameScoreCalculator.BeginGame();
            Assert.Equal(_welcomeMessage,tennisGameScoreCalculatorWelcomeMessage);
        }
    }
}
