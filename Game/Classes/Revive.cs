using System;
using Game.Enums;

namespace Game.Classes
{
    public class Revive : Spell
    {
        public Revive() : base(130, true, false){}
        
        public override void Cast(MagicCharacter magicCharacter, Character character)
        {
            if (magicCharacter.CurrentMP >= ManaCost && magicCharacter.CurrentTalkAbillity)
            {
                if (character.State == State.Dead)
                {
                    magicCharacter.CurrentMP -= ManaCost;
                    character.CurrentHP = 1;
                    character.State = Methods.RandomState(State.Normal, State.Weakened);
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Revive spell is Cast"); };
                    character.CharacterEvent += delegate { Console.WriteLine("Revive spell is Cast"); };
                }
                else
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Character isn't dead"); };
            }
            else
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast ReviveSpell"); };
        }
        public override void Cast(MagicCharacter magicCharacter, MagicCharacter character)
        {
            if (magicCharacter.CurrentMP >= ManaCost && magicCharacter.CurrentTalkAbillity && magicCharacter.Id != character.Id)
            {
                if (character.State == State.Dead)
                {
                    magicCharacter.CurrentMP -= ManaCost;
                    character.CurrentHP = 1;
                    character.State = Methods.RandomState(State.Normal, State.Weakened);
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Revive spell is Cast"); };
                    character.CharacterEvent += delegate { Console.WriteLine("Revive spell is Cast"); };
                }
                else
                    magicCharacter.CharacterEvent += delegate { Console.WriteLine("Character isn't dead"); };
            }
            else
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast ReviveSpell"); };
        }
    }
}