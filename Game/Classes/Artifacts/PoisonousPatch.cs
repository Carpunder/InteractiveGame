using System;
using Game.Enums;

namespace Game.Classes.Artifacts
{
    public class PoisonousPatch : Artifact
    {
        public PoisonousPatch(): base(true, 0){}

        public override void Use(Character holder, Character target, uint power)
        {
            if (!(target.State == State.Normal || target.State == State.Weakened) || power > target.CurrentHP)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use PoisonousPatch"); };
                return;
            }
            target.CurrentHP -= power;
            target.State = State.Poisoned;
            holder.CharacterEvent += delegate { Console.WriteLine("PoisonousPatch is used"); };
            target.CharacterEvent += delegate { Console.WriteLine($"PoisonousPatch is used\n" +
                                                                  $"Current State: {target.State}\n" +
                                                                  $"Current HP: {target.CurrentHP}"); };
        }

        public override void Use(Character holder, MagicCharacter target, uint power = 0)
        {
            if (!(target.State == State.Normal || target.State == State.Weakened) || power > target.CurrentHP)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use PoisonousPatch"); };
                return;
            }
            target.CurrentHP -= power;
            target.State = State.Poisoned;
            holder.CharacterEvent += delegate { Console.WriteLine("PoisonousPatch is used"); };
            target.CharacterEvent += delegate { Console.WriteLine($"PoisonousPatch is used\n" +
                                                                  $"Current State: {target.State}\n" +
                                                                  $"Current HP: {target.CurrentHP}"); };
        }

        public override void Use(MagicCharacter holder, Character target, uint power)
        {
            if (!(target.State == State.Normal || target.State == State.Weakened) || power > target.CurrentHP)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use PoisonousPatch"); };
                return;
            }
            target.CurrentHP -= power;
            target.State = State.Poisoned;
            holder.CharacterEvent += delegate { Console.WriteLine("PoisonousPatch is used"); };
            target.CharacterEvent += delegate { Console.WriteLine($"PoisonousPatch is used\n" +
                                                                  $"Current State: {target.State}\n" +
                                                                  $"Current HP: {target.CurrentHP}"); };
        }

        public override void Use(MagicCharacter holder, MagicCharacter target, uint power = 0)
        {
            if (!(target.State == State.Normal || target.State == State.Weakened) || power > target.CurrentHP)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use PoisonousPatch"); };
                return;
            }
            target.CurrentHP -= power;
            target.State = State.Poisoned;
            holder.CharacterEvent += delegate { Console.WriteLine("PoisonousPatch is used"); };
            target.CharacterEvent += delegate { Console.WriteLine($"PoisonousPatch is used\n" +
                                                                  $"Current State: {target.State}\n" +
                                                                  $"Current HP: {target.CurrentHP}"); };
        }

        public override string ToString()
        {
            return "PoisonousPatch";
        }
    }
}