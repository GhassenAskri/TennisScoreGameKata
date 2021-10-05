using System;

namespace TennisGameScore
{
    public static class Winner 
    {
        public static string GetTheWinnerName(Player firstPlayer, Player secondPlayer)
        {
            if(secondPlayer.Score.Contains("winner"))
                return secondPlayer.Name;
            return firstPlayer.Name;
        }
    }
}