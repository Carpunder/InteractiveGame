using System;
using Game.Classes;
using Game.Enums;

namespace Game
{
    public static class Program
    {
        public static int id;

        private static void Main()
        {
            var person = new MagicCharacter(
                "Misha", true, true,
                Race.Orc, Sex.Male, 19, 2000, 500,5000, 5000, 5000);
            
            var personCharacter = new Character(
                "Ghrisha", true, true,
                Race.Elf, Sex.Male, 19, 2000, 500,5000);
            
            
        }
    }
}