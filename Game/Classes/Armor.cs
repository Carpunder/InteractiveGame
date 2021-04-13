using System;
using System.Threading;
using Game.Enums;

namespace Game.Classes
{
    public class Armor : Spell
    {
        public Armor() : base(50, false,false){}

        public override void Cast(MagicCharacter magicCharacter, uint time)
        {
            if (magicCharacter.CurrentMP >= ManaCost * time)
            {
                magicCharacter.CurrentMP -= ManaCost * time;
                Thread.Sleep((int) (time*1000));
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Armor spell is Cast\n" +
                                                                              $"Time: {time} sec.\n" +
                                                                              $"Current MP: {magicCharacter.CurrentMP}"); };
            }
            else
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana " +
                                                                              "to cast Armor Spell"); };
        }

        public override void Cast(MagicCharacter magicCharacter, Character character, uint time)
        {
            if (magicCharacter.CurrentMP >= ManaCost * time)
            {
                magicCharacter.CurrentMP -= ManaCost * time;
                Thread.Sleep((int) (time*1000));
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Armor spell is Cast\n" +
                                                                              $"Time: {time} sec.\n" +
                                                                              $"Current MP: {magicCharacter.CurrentMP}"); };
                character.CharacterEvent += delegate { Console.WriteLine("Armor spell is Cast\n" +
                                                                         $"Time: {time} sec.\n" ); };
            }
            else
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana " +
                                                                              "to cast Armor Spell"); };
        }

        public override void Cast(MagicCharacter magicCharacter, MagicCharacter character, uint time)
        {
            if (magicCharacter.CurrentMP >= ManaCost * time)
            {
                magicCharacter.CurrentMP -= ManaCost * time;
                Thread.Sleep((int) (time*1000));
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Armor spell is Cast\n" +
                                                                              $"Time: {time} sec.\n" +
                                                                              $"Current MP: {magicCharacter.CurrentMP}"); };
                character.CharacterEvent += delegate { Console.WriteLine("Armor spell is Cast\n" +
                                                                         $"Time: {time} sec.\n" ); };
            }
            else
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana " +
                                                                              "to cast Armor Spell"); };
        }
    }
}