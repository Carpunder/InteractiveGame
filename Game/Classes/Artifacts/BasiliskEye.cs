using System;
using Game.Enums;

namespace Game.Classes.Artifacts
{
    public class BasiliskEye : Artifact
    {
        public BasiliskEye(): base(false, 0){}

        public override void Use(Character holder, Character target, uint power = 0)
        {
            if (target.State == State.Dead)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use BasiliskEye"); };
                return;
            }

            target.State = State.Paralyzed;
            holder.CharacterEvent += delegate { Console.WriteLine("BasiliskEye is used"); };
            target.CharacterEvent += delegate { Console.WriteLine("BasiliskEye is used\n" +
                                                                  "Current state: Paralyzed"); };
            holder.Inventory.Remove(this);
        }

        public override void Use(Character holder, MagicCharacter target, uint power = 0)
        {
            if (target.State == State.Dead)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use BasiliskEye"); };
                return;
            }

            target.State = State.Paralyzed;
            holder.CharacterEvent += delegate { Console.WriteLine("BasiliskEye is used"); };
            target.CharacterEvent += delegate { Console.WriteLine("BasiliskEye is used\n" +
                                                                  "Current state: Paralyzed"); };
            holder.Inventory.Remove(this);
        }

        public override void Use(MagicCharacter holder, Character target, uint power = 0)
        {
            if (target.State == State.Dead)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use BasiliskEye"); };
                return;
            }

            target.State = State.Paralyzed;
            holder.CharacterEvent += delegate { Console.WriteLine("BasiliskEye is used"); };
            target.CharacterEvent += delegate { Console.WriteLine("BasiliskEye is used\n" +
                                                                  "Current state: Paralyzed"); };
            holder.Inventory.Remove(this);
        }

        public override void Use(MagicCharacter holder, MagicCharacter target, uint power = 0)
        {
            if (target.State == State.Dead)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use BasiliskEye"); };
                return;
            }

            target.State = State.Paralyzed;
            holder.CharacterEvent += delegate { Console.WriteLine("BasiliskEye is used"); };
            target.CharacterEvent += delegate { Console.WriteLine("BasiliskEye is used\n" +
                                                                  "Current state: Paralyzed"); };
            holder.Inventory.Remove(this);
        }

        public override string ToString()
        {
            return "BasiliskEye";
        }
    }
}