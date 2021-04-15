using Game.Classes;

namespace Game.Interfaces
{
    public interface IArtifact
    {
        public void Use(Character holder, uint power);
        public void Use(MagicCharacter holder, uint power);
        public void Use(Character holder, Character target, uint power);
        public void Use(Character holder, MagicCharacter target, uint power);
        public void Use(MagicCharacter holder, Character target, uint power);
        public void Use(MagicCharacter holder, MagicCharacter target, uint power);
    }
}