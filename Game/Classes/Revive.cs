using System;
using Game.Enums;

namespace Game.Classes
{
    public class Revive : Spell
    {
        public Revive() : base(130, true, false){}
        
        public override void Cast(MagicCharacter caster, Character target)
        {
            if (caster.CurrentMP >= ManaCost && caster.CurrentTalkAbillity)
            {
                if (target.State == State.Dead)
                {
                    caster.CurrentMP -= ManaCost;
                    target.CurrentHP = 1;
                    target.State = Methods.RandomState(State.Normal, State.Weakened);
                    caster.CharacterEvent += delegate { Console.WriteLine("Revive spell is Cast"); };
                    target.CharacterEvent += delegate { Console.WriteLine("Revive spell is Cast"); };
                }
                else
                    caster.CharacterEvent += delegate { Console.WriteLine("Character isn't dead"); };
            }
            else
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast ReviveSpell"); };
        }
        public override void Cast(MagicCharacter caster, MagicCharacter target)
        {
            if (caster.CurrentMP >= ManaCost && caster.CurrentTalkAbillity && caster.Id != target.Id)
            {
                if (target.State == State.Dead)
                {
                    caster.CurrentMP -= ManaCost;
                    target.CurrentHP = 1;
                    target.State = Methods.RandomState(State.Normal, State.Weakened);
                    caster.CharacterEvent += delegate { Console.WriteLine("Revive spell is Cast"); };
                    target.CharacterEvent += delegate { Console.WriteLine("Revive spell is Cast"); };
                }
                else
                    caster.CharacterEvent += delegate { Console.WriteLine("Character isn't dead"); };
            }
            else
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast ReviveSpell"); };
        }
    }
}