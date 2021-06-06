using Game.Interfaces;

namespace Game.Classes
{
    public abstract class Artifact : IArtifact
    {
        public bool Renewable { get; private set; }
        public uint Power { get; set; }
        
        protected Artifact(){}
        protected Artifact(bool renewable, uint power)
        {
            Renewable = renewable;
            Power = power;
        }
        
        public virtual void Use(Character holder, uint power = 0){}
        public virtual void Use(MagicCharacter holder, uint power = 0){}
        public virtual void Use(Character holder, Character target, uint power = 0){}
        public virtual void Use(Character holder, MagicCharacter target, uint power = 0){}
        public virtual void Use(MagicCharacter holder, Character target, uint power = 0){}
        public virtual void Use(MagicCharacter holder, MagicCharacter target, uint power = 0){}
    }
}