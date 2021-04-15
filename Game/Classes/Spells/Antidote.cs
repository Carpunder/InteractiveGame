using System;
using Game.Enums;

namespace Game.Classes
{
    public class Antidote : Spell
    {
        public Antidote() : base(30, false, false){}
        
        public override void Cast(MagicCharacter caster)
        {
            if (caster.CurrentMP >= ManaCost)
            { 
                if (caster.State == State.Poisoned)
                {
                    caster.CurrentMP -= ManaCost;
                    caster.State = Methods.RandomState(State.Normal, State.Weakened);
                    caster.CharacterEvent += delegate { Console.WriteLine("Antidote spell is Cast"); };
                }
                else
                    caster.CharacterEvent += delegate { Console.WriteLine("Character isn't poisoned"); };
            }
            else
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast AntidoteSpell"); };
        }
        public override void Cast(MagicCharacter caster, Character target)
        {
            if (caster.CurrentMP >= ManaCost)
            {
                if (target.State == State.Poisoned)
                {
                    caster.CurrentMP -= ManaCost;
                    target.State = Methods.RandomState(State.Normal, State.Weakened);
                    caster.CharacterEvent += delegate { Console.WriteLine("Antidote spell is Cast"); };
                    target.CharacterEvent += delegate { Console.WriteLine("Antidote spell is Cast"); };
                }
                else
                    caster.CharacterEvent += delegate { Console.WriteLine("Character isn't poisoned"); };
            }
            else
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast AntidoteSpell"); };
        }
        public override void Cast(MagicCharacter caster, MagicCharacter target)
        {
            if (caster.CurrentMP >= ManaCost)
            {
                if (target.State == State.Poisoned)
                {
                    caster.CurrentMP -= ManaCost;
                    target.State = Methods.RandomState(State.Normal, State.Weakened);
                    caster.CharacterEvent += delegate { Console.WriteLine("Antidote spell is Cast"); };
                    target.CharacterEvent += delegate { Console.WriteLine("Antidote spell is Cast"); };
                }
                else
                    caster.CharacterEvent += delegate { Console.WriteLine("Character isn't poisoned"); };
            }
            else
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana to cast AntidoteSpell"); };
        }
        
    }
}