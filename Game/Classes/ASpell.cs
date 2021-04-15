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

        public virtual void Cast(MagicCharacter caster, Character target){}
        public virtual void Cast(MagicCharacter caster, MagicCharacter target){}
        public virtual void Cast(MagicCharacter caster){}
        public virtual void Cast(MagicCharacter caster, Character target, uint power){}
        public virtual void Cast(MagicCharacter caster, MagicCharacter target, uint power){}
        public virtual void Cast(MagicCharacter caster, uint power){}
    }
}