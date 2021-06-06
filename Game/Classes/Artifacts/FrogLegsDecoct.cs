using System;
using Game.Enums;

namespace Game.Classes.Artifacts
{
    public class FrogLegsDecoct : Artifact
    {
        public FrogLegsDecoct(): base(false, 0){}

        public override void Use(Character holder, Character target, uint power = 0)
        {
            if (target.State != State.Poisoned)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use FrogLegsDecoct"); };
                return;
            }

            target.State = Methods.RandomState(State.Normal, State.Weakened);
            holder.CharacterEvent += delegate { Console.WriteLine("FrogLegsDecoct is used"); };
            target.CharacterEvent += delegate { Console.WriteLine("FrogLegsDecoct is used" +
                                                                  $"Current State: {target.State}"); };
            holder.Inventory.Remove(this);
        }

        public override void Use(Character holder, MagicCharacter target, uint power = 0)
        {
            if (target.State != State.Poisoned)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use FrogLegsDecoct"); };
                return;
            }

            target.State = Methods.RandomState(State.Normal, State.Weakened);
            holder.CharacterEvent += delegate { Console.WriteLine("FrogLegsDecoct is used"); };
            target.CharacterEvent += delegate { Console.WriteLine("FrogLegsDecoct is used" +
                                                                  $"Current State: {target.State}"); };
            holder.Inventory.Remove(this);
        }

        public override void Use(MagicCharacter holder, Character target, uint power = 0)
        {
            if (target.State != State.Poisoned)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use FrogLegsDecoct"); };
                return;
            }

            target.State = Methods.RandomState(State.Normal, State.Weakened);
            holder.CharacterEvent += delegate { Console.WriteLine("FrogLegsDecoct is used"); };
            target.CharacterEvent += delegate { Console.WriteLine("FrogLegsDecoct is used" +
                                                                  $"Current State: {target.State}"); };
            holder.Inventory.Remove(this);
        }

        public override void Use(MagicCharacter holder, MagicCharacter target, uint power = 0)
        {
            if (target.State != State.Poisoned)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use FrogLegsDecoct"); };
                return;
            }

            target.State = Methods.RandomState(State.Normal, State.Weakened);
            holder.CharacterEvent += delegate { Console.WriteLine("FrogLegsDecoct is used"); };
            target.CharacterEvent += delegate { Console.WriteLine("FrogLegsDecoct is used" +
                                                                  $"Current State: {target.State}"); };
            holder.Inventory.Remove(this);
        }

        public override string ToString()
        {
            return "FrogLegsDecoct";
        }
    }
}