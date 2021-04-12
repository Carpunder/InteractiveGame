using System;
using Game.Enums;

namespace Game.Classes
{
    public class Antidote : Spell
    {
        public Antidote() : base(30, false, false){}
        
        public override void Cast(MagicCharacter magicCharacter)
        {
            if (magicCharacter.CurrentMP >= ManaCost)
            { 
                if (magicCharacter.State == State.Poisoned)
                {
                    magicCharacter.CurrentMP -= ManaCost;
                    magicCharacter.State = Methods.RandomState(State.Normal, State.Weakened);
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Antidote spell is Cast"); };
                }
                else
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Character isn't poisoned"); };
            }
            else
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast AntidoteSpell"); };
        }
        public override void Cast(MagicCharacter magicCharacter, Character character)
        {
            if (magicCharacter.CurrentMP >= ManaCost)
            {
                if (character.State == State.Poisoned)
                {
                    magicCharacter.CurrentMP -= ManaCost;
                    character.State = Methods.RandomState(State.Normal, State.Weakened);
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Antidote spell is Cast"); };
                    character.CharacterEvent += delegate { Console.WriteLine("Antidote spell is Cast"); };
                }
                else
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Character isn't poisoned"); };
            }
            else
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast AntidoteSpell"); };
        }
        public override void Cast(MagicCharacter magicCharacter, MagicCharacter character)
        {
            if (magicCharacter.CurrentMP >= ManaCost)
            {
                if (character.State == State.Poisoned)
                {
                    magicCharacter.CurrentMP -= ManaCost;
                    character.State = Methods.RandomState(State.Normal, State.Weakened);
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Antidote spell is Cast"); };
                    character.CharacterEvent += delegate { Console.WriteLine("Antidote spell is Cast"); };
                }
                else
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Character isn't poisoned"); };
            }
            else
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast AntidoteSpell"); };
        }
        
    }
}