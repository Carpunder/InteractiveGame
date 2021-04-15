using Game.Classes;

namespace Game.Interfaces
{
    public interface IMagic
    {
        public void Cast(MagicCharacter caster, Character target);
        public void Cast(MagicCharacter caster, MagicCharacter target);
        public void Cast(MagicCharacter caster);
        public void Cast(MagicCharacter caster, Character target, uint power);
        public void Cast(MagicCharacter caster, MagicCharacter target, uint power);
        public void Cast(MagicCharacter caster, uint power);
    }
}