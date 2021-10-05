using System;

namespace TennisGameScore
{
    public static class Winner 
    {
        private static string _gameBallPoint = "winner";
        public static string GetTheWinnerName(Player firstPlayer, Player secondPlayer)
        {
            if(secondPlayer.Score.Contains(_gameBallPoint))
                return secondPlayer.Name;
            return firstPlayer.Name;
        }
    }
}