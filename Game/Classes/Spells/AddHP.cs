using System;

namespace Game.Classes
{
    class AddHP : Spell
    {
        public AddHP() : base(0, true, false){}
        
        public override void Cast(MagicCharacter caster, uint mana)
        {
            if (caster.CurrentMP >= mana && caster.CurrentTalkAbillity)
            {
                for (uint i = 1; i <= mana; i += 2)
                {
                    if(caster.CurrentHP >= caster.MaxHP)
                        break;
                    caster.CurrentHP += 1;
                    caster.CurrentMP -= 2;
                }
                caster.CharacterEvent += delegate { Console.WriteLine("AddHP spell is Cast\n" +
                                                                              $"Current HP:{caster.CurrentHP}\n" +
                                                                              $"Current MP: {caster.CurrentMP}"); };
            }
            else
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana or no speak abillity " +
                                                                              "to cast AddHP Spell"); };
        }

        public override void Cast(MagicCharacter caster, Character target, uint mana)
        {
            if (caster.CurrentMP >= mana && caster.CurrentTalkAbillity)
            {
                for (uint i = 1; i <= mana; i += 2)
                {
                    if(target.CurrentHP >= target.MaxHP)
                        break;
                    target.CurrentHP += 1;
                    caster.CurrentMP -= 2;
                }
                caster.CharacterEvent += delegate { Console.WriteLine("AddHP spell is Cast\n" +
                                                                      $"Current MP: {caster.CurrentMP}"); };
                target.CharacterEvent += delegate { Console.WriteLine("AddHP spell is Cast\n" +
                                                                         $"Current HP: {target.CurrentHP}"); };
            }
            else
            {
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana or no speak abillity " +
                                                                              "to cast AddHP Spell"); };
            }
        }
        
        public override void Cast(MagicCharacter caster, MagicCharacter target, uint mana)
        {
            if (caster.CurrentMP >= mana && caster.CurrentTalkAbillity)
            {
                for (uint i = 1; i <= mana; i += 2)
                {
                    if(target.CurrentHP >= target.MaxHP)
                        break;
                    target.CurrentHP += 1;
                    caster.CurrentMP -= 2;
                }
                caster.CharacterEvent += delegate { Console.WriteLine("AddHP spell is Cast\n" +
                                                                              $"Current MP: {caster.CurrentMP}"); };
                target.CharacterEvent += delegate { Console.WriteLine("AddHP spell is Cast\n" +
                                                                         $"Current HP: {target.CurrentHP}"); };
            }
            else
            {
                caster.CharacterEvent += delegate { Console.WriteLine("Not Enough mana or no speak abillity " +
                                                                              "to cast AddHP Spell"); };
            }
        }

        public override string ToString()
        {
            return "AddHP";
        }
    }
}