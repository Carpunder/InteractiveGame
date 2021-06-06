using System;
using Game.Enums;

namespace Game.Classes
{
    public class Heal : Spell
    {
        public Heal() : base(20, false, false){}

       public override void Cast(MagicCharacter caster)
        {
            if (caster.CurrentMP >= ManaCost)
            { 
                if (caster.State == State.Seek)
                {
                    caster.CurrentMP -= ManaCost;
                    caster.State = Methods.RandomState(State.Normal, State.Weakened);
                    caster.CharacterEvent += delegate { Console.WriteLine("Heal spell is Cast"); };
                }
                else
                    caster.CharacterEvent += delegate { Console.WriteLine("Character isn't seek"); };
            }
            else
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast HealSpell"); };
        }
        public override void Cast(MagicCharacter caster, Character target)
        {
            if (caster.CurrentMP >= ManaCost)
            {
                if (target.State == State.Seek)
                {
                    caster.CurrentMP -= ManaCost;
                    target.State = Methods.RandomState(State.Normal, State.Weakened);
                    caster.CharacterEvent += delegate { Console.WriteLine("Heal spell is Cast"); };
                    target.CharacterEvent += delegate { Console.WriteLine("Heal spell is Cast"); };
                }
                else
                    caster.CharacterEvent += delegate { Console.WriteLine("Character isn't seek"); };
            }
            else
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast HealSpell"); };
        }
        public override void Cast(MagicCharacter caster, MagicCharacter target)
        {
            if (caster.CurrentMP >= ManaCost)
            {
                if (target.State == State.Seek)
                {
                    caster.CurrentMP -= ManaCost;
                    target.State = Methods.RandomState(State.Normal, State.Weakened);
                    caster.CharacterEvent += delegate { Console.WriteLine("Heal spell is Cast"); };
                    target.CharacterEvent += delegate { Console.WriteLine("Heal spell is Cast"); };
                }
                else
                    caster.CharacterEvent += delegate { Console.WriteLine("Character isn't seek"); };
            }
            else
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast HealSpell"); };
        }

        public override string ToString()
        {
            return "Heal";
        }
    }
}