using Game.Interfaces;

namespace Game.Classes
{
    public abstract class Spell : IMagic
    {
        public uint ManaCost { get; private set; }
        public bool SpeakToCast { get; private set; }
        public bool MoveToCast { get; private set; }

        protected Spell(){}
        protected Spell(uint manaCost, bool speakToCast, bool moveToCast)
        {
            ManaCost = manaCost;
            SpeakToCast = speakToCast;
            MoveToCast = moveToCast;
        }

        public virtual void Cast(MagicCharacter magicCharacter, Character character){}
        public virtual void Cast(MagicCharacter magicCharacter, MagicCharacter character){}
        public virtual void Cast(MagicCharacter magicCharacter){}
        public virtual void Cast(MagicCharacter magicCharacter, Character character, uint power){}
        public virtual void Cast(MagicCharacter magicCharacter, MagicCharacter character, uint power){}
        public virtual void Cast(MagicCharacter magicCharacter, uint power){}
    }
}