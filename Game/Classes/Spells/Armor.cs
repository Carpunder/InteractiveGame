using System;
using System.Threading;
using Game.Enums;

namespace Game.Classes
{
    public class Armor : Spell
    {
        public Armor() : base(50, false,false){}

        public override void Cast(MagicCharacter caster, uint time)
        {
            if (caster.CurrentMP >= ManaCost * time)
            {
                caster.CurrentMP -= ManaCost * time;
                Thread.Sleep((int) (time*1000));
                caster.CharacterEvent += delegate { Console.WriteLine("Armor spell is Cast\n" +
                                                                              $"Time: {time} sec.\n" +
                                                                              $"Current MP: {caster.CurrentMP}"); };
            }
            else
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana " +
                                                                              "to cast Armor Spell"); };
        }

        public override void Cast(MagicCharacter caster, Character target, uint time)
        {
            if (caster.CurrentMP >= ManaCost * time)
            {
                caster.CurrentMP -= ManaCost * time;
                Thread.Sleep((int) (time*1000));
                caster.CharacterEvent += delegate { Console.WriteLine("Armor spell is Cast\n" +
                                                                              $"Time: {time} sec.\n" +
                                                                              $"Current MP: {caster.CurrentMP}"); };
                target.CharacterEvent += delegate { Console.WriteLine("Armor spell is Cast\n" +
                                                                         $"Time: {time} sec.\n" ); };
            }
            else
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana " +
                                                                              "to cast Armor Spell"); };
        }

        public override void Cast(MagicCharacter caster, MagicCharacter target, uint time)
        {
            if (caster.CurrentMP >= ManaCost * time)
            {
                caster.CurrentMP -= ManaCost * time;
                Thread.Sleep((int) (time*1000));
                caster.CharacterEvent += delegate { Console.WriteLine("Armor spell is Cast\n" +
                                                                              $"Time: {time} sec.\n" +
                                                                              $"Current MP: {caster.CurrentMP}"); };
                target.CharacterEvent += delegate { Console.WriteLine("Armor spell is Cast\n" +
                                                                         $"Time: {time} sec.\n" ); };
            }
            else
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana " +
                                                                              "to cast Armor Spell"); };
        }

        public override string ToString()
        {
            return "Armor";
        }
    }
}