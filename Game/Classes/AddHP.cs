using System;

namespace Game.Classes
{
    class AddHP : Spell
    {
        public AddHP() : base(0, true, false){}
        
        public override void Cast(MagicCharacter magicCharacter, uint mana)
        {
            if (magicCharacter.CurrentMP >= mana && magicCharacter.CurrentTalkAbillity)
            {
                for (uint i = 1; i <= mana; i += 2)
                {
                    if(magicCharacter.CurrentHP >= magicCharacter.MaxHP)
                        break;
                    magicCharacter.CurrentHP += 1;
                    magicCharacter.CurrentMP -= 2;
                }
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("AddHP spell is Cast\n" +
                                                                              $"Current HP:{magicCharacter.CurrentHP}\n" +
                                                                              $"Current MP: {magicCharacter.CurrentMP}"); };
            }
            else
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana or no speak abillity " +
                                                                              "to cast AddHP Spell"); };
        }

        public override void Cast(MagicCharacter magicCharacter, Character character, uint mana)
        {
            if (magicCharacter.CurrentMP >= mana && magicCharacter.CurrentTalkAbillity)
            {
                for (uint i = 1; i <= mana; i += 2)
                {
                    if(character.CurrentHP >= character.MaxHP)
                        break;
                    character.CurrentHP += 1;
                    magicCharacter.CurrentMP -= 2;
                }
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("AddHP spell is Cast\n" +
                                                                              $"Current MP: {magicCharacter.CurrentMP}"); };
                character.CharacterEvent += delegate { Console.WriteLine("AddHP spell is Cast\n" +
                                                                         $"Current HP: {character.CurrentHP}"); };
            }
            else
            {
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana or no speak abillity " +
                                                                              "to cast AddHP Spell"); };
            }
        }
        
        public override void Cast(MagicCharacter magicCharacter, MagicCharacter character, uint mana)
        {
            if (magicCharacter.CurrentMP >= mana && magicCharacter.CurrentTalkAbillity)
            {
                for (uint i = 1; i <= mana; i += 2)
                {
                    if(character.CurrentHP >= character.MaxHP)
                        break;
                    character.CurrentHP += 1;
                    magicCharacter.CurrentMP -= 2;
                }
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("AddHP spell is Cast\n" +
                                                                              $"Current MP: {magicCharacter.CurrentMP}"); };
                character.CharacterEvent += delegate { Console.WriteLine("AddHP spell is Cast\n" +
                                                                         $"Current HP: {character.CurrentHP}"); };
            }
            else
            {
                magicCharacter.CharacterEvent += delegate { Console.WriteLine("Not Enough mana or no speak abillity " +
                                                                              "to cast AddHP Spell"); };
            }
        }
    }
}