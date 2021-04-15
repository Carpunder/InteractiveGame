using System;
using Game.Enums;

namespace Game.Classes
{
    public class Unfreeze : Spell
    {
        public Unfreeze() : base(85, true,false){}
        
        public override void Cast(MagicCharacter magicCharacter, Character character)
        {
            if (magicCharacter.CurrentMP >= ManaCost && magicCharacter.CurrentTalkAbillity)
            {
                if (character.State == State.Paralyzed)
                {
                    magicCharacter.CurrentMP -= ManaCost;
                    character.CurrentHP = 1;
                    character.State = Methods.RandomState(State.Normal, State.Weakened);
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Unfreeze spell is Cast"); };
                    character.CharacterEvent += delegate { Console.WriteLine("Unfreeze spell is Cast"); };
                }
                else
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Character isn't paralyzed"); };
            }
            else
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast UnfreezeSpell"); };
        }
        public override void Cast(MagicCharacter magicCharacter, MagicCharacter character)
        {
            if (magicCharacter.CurrentMP >= ManaCost && magicCharacter.CurrentTalkAbillity && magicCharacter.Id != character.Id)
            {
                if (character.State == State.Paralyzed)
                {
                    magicCharacter.CurrentMP -= ManaCost;
                    character.CurrentHP = 1;
                    character.State = Methods.RandomState(State.Normal, State.Weakened);
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Unfreeze spell is Cast"); };
                    character.CharacterEvent += delegate { Console.WriteLine("Unfreeze spell is Cast"); };
                }
                else
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Character isn't paralyzed"); };
            }
            else
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast UnfreezeSpell"); };
        }
        
    }
}