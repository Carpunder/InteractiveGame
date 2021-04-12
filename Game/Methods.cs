using System;
using Game.Enums;

namespace Game
{
    public static class Methods
    {
        private static readonly Random _random = new Random();
        
        public static State RandomState(State first, State second) => _random.Next(0, 2) == 0 ? first : second;
    }
}