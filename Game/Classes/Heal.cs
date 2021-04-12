using System;
using Game.Enums;

namespace Game.Classes
{
    public class Heal : Spell
    {
        public Heal() : base(20, false, false){}

       public override void Cast(MagicCharacter magicCharacter)
        {
            if (magicCharacter.CurrentMP >= ManaCost)
            { 
                if (magicCharacter.State == State.Seek)
                {
                    magicCharacter.CurrentMP -= ManaCost;
                    magicCharacter.State = Methods.RandomState(State.Normal, State.Weakened);
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Heal spell is Cast"); };
                }
                else
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Character isn't seek"); };
            }
            else
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast HealSpell"); };
        }
        public override void Cast(MagicCharacter magicCharacter, Character character)
        {
            if (magicCharacter.CurrentMP >= ManaCost)
            {
                if (character.State == State.Seek)
                {
                    magicCharacter.CurrentMP -= ManaCost;
                    character.State = Methods.RandomState(State.Normal, State.Weakened);
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Heal spell is Cast"); };
                    character.CharacterEvent += delegate { Console.WriteLine("Heal spell is Cast"); };
                }
                else
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Character isn't seek"); };
            }
            else
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast HealSpell"); };
        }
        public override void Cast(MagicCharacter magicCharacter, MagicCharacter character)
        {
            if (magicCharacter.CurrentMP >= ManaCost)
            {
                if (character.State == State.Seek)
                {
                    magicCharacter.CurrentMP -= ManaCost;
                    character.State = Methods.RandomState(State.Normal, State.Weakened);
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Heal spell is Cast"); };
                    character.CharacterEvent += delegate { Console.WriteLine("Heal spell is Cast"); };
                }
                else
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Character isn't seek"); };
            }
            else
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast HealSpell"); };
        }
    }
}