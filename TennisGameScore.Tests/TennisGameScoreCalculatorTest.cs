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
    
        #endregion

        #region Tests
        [Fact]
        public void When_The_First_Player_Win_The_First_Ball()
        {
            //Given
            _firstPlayer.HasWinTheBall(0);
            //When
            
            //Assert
            Assert.True(_firstPlayer.Score == "love");
        }
        [Fact]
        public void When_The_First_Player_Win_The_First_And_The_Second_Ball()
        {
            //Given
            _firstPlayer.HasWinTheBall(0);
            _firstPlayer.HasWinTheBall(1);      
            //When

            //Assert
            Assert.True(_firstPlayer.Score == "love fifteen");
        }
        [Fact]
        public void When_The_First_Player_Win_The_First_The_Second_And_The_Third_Ball()
        {
            //Given
            _firstPlayer.HasWinTheBall(0);
            _firstPlayer.HasWinTheBall(1);          
            _firstPlayer.HasWinTheBall(2);
            
            //When

            //Assert
            Assert.True(_firstPlayer.Score == "love fifteen thirteen");
        }

         [Fact]
        public void When_The_First_Player_Win_The_First_The_Second_The_Third_And_The_Fourth_Ball()
        {
            //Given
            _firstPlayer.HasWinTheBall(0);
            _firstPlayer.HasWinTheBall(1);          
            _firstPlayer.HasWinTheBall(2);
            _firstPlayer.HasWinTheBall(3);
            
            //When

            //Assert
            Assert.True(_firstPlayer.Score == "love fifteen thirteen fourteen");
        }
        #endregion
    }
}
