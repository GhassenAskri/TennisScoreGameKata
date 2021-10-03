using System;
using Xunit;
using TennisGameScore;

namespace TennisGameScore.Tests
{
    public class TennisGameScoreCalculatorTest
    {
        [Fact]
        public void WHEN_THE_TENNIS_SCORE_GAME_BEGIN_WELCOME_MESSAGE_SHOULD_BE_PROMPED()
        {
            TennisGameScoreCalculator tennisGameScoreCalculator = new TennisGameScoreCalculator();
            string tennisGameScoreCalculatorWelcomeMessage = tennisGameScoreCalculator.BeginGame();
            Assert.Equal("Wellcome to the tennis game",tennisGameScoreCalculatorWelcomeMessage);
        }
    }
}
