using System;
using Game.Enums;

namespace Game.Classes
{
    public class Unfreeze : Spell
    {
        public Unfreeze() : base(85, true,false){}
        
        public override void Cast(MagicCharacter caster, Character target)
        {
            if (caster.CurrentMP >= ManaCost && caster.CurrentTalkAbillity)
            {
                if (target.State == State.Paralyzed)
                {
                    caster.CurrentMP -= ManaCost;
                    target.CurrentHP = 1;
                    target.State = Methods.RandomState(State.Normal, State.Weakened);
                    caster.CharacterEvent += delegate { Console.WriteLine("Unfreeze spell is Cast"); };
                    target.CharacterEvent += delegate { Console.WriteLine("Unfreeze spell is Cast"); };
                }
                else
                    caster.CharacterEvent += delegate { Console.WriteLine("Character isn't paralyzed"); };
            }
            else
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast UnfreezeSpell"); };
        }
        public override void Cast(MagicCharacter caster, MagicCharacter target)
        {
            if (caster.CurrentMP >= ManaCost && caster.CurrentTalkAbillity && caster.Id != target.Id)
            {
                if (target.State == State.Paralyzed)
                {
                    caster.CurrentMP -= ManaCost;
                    target.CurrentHP = 1;
                    target.State = Methods.RandomState(State.Normal, State.Weakened);
                    caster.CharacterEvent += delegate { Console.WriteLine("Unfreeze spell is Cast"); };
                    target.CharacterEvent += delegate { Console.WriteLine("Unfreeze spell is Cast"); };
                }
                else
                    caster.CharacterEvent += delegate { Console.WriteLine("Character isn't paralyzed"); };
            }
            else
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast UnfreezeSpell"); };
        }

        public override string ToString()
        {
            return "Unfreeze";
        }
    }
}