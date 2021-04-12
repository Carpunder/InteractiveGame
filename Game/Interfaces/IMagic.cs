using Game.Classes;

namespace Game.Interfaces
{
    public interface IMagic
    {
        public void Cast(MagicCharacter magicCharacter, Character character);
        public void Cast(MagicCharacter magicCharacter, MagicCharacter character);
        public void Cast(MagicCharacter magicCharacter);
        public void Cast(MagicCharacter magicCharacter, Character character, uint power);
        public void Cast(MagicCharacter magicCharacter, MagicCharacter character, uint power);
        public void Cast(MagicCharacter magicCharacter, uint power);
    }
}