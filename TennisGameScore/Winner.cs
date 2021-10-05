using System;

namespace TennisGameScore
{
    public static class Winner 
    {
        public static string GetTheWinnerName(TennisPlayer firstPlayer, TennisPlayer secondPlayer)
        {
                return firstPlayer.Name;
        }
    }
}