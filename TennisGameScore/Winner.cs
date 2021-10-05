using System;

namespace TennisGameScore
{
    public static class Winner 
    {
        public static string GetTheWinnerName(Player firstPlayer, Player secondPlayer)
        {
                return firstPlayer.Name;
        }
    }
}