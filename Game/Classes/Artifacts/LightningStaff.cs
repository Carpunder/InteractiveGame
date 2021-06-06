using System;
using Microsoft.VisualBasic;

namespace Game.Classes.Artifacts
{
    public class LightningStaff: Artifact
    {
        public LightningStaff() : base(true, 100) {}

        public override void Use(Character holder, Character target, uint power)
        {
            if (target.CurrentHP < power || power > Power)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use LightningStaff!"); };
                return;
            }

            target.CurrentHP -= power;
            Power -= power;
            holder.CharacterEvent += delegate { Console.WriteLine($"LightningStaff is used\n" +
                                                                  $"Current LightningStaff Power: {Power}"); };
            target.CharacterEvent += delegate { Console.WriteLine($"LightningStaff is used\n" +
                                                                  $"Current HP: {target.CurrentHP}"); };
        }

        public override void Use(Character holder, MagicCharacter target, uint power)
        {
            if (target.CurrentHP < power || power > Power)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use LightningStaff!"); };
                return;
            }

            target.CurrentHP -= power;
            Power -= power;
            holder.CharacterEvent += delegate { Console.WriteLine($"LightningStaff is used\n" +
                                                                  $"Current LightningStaff Power: {Power}"); };
            target.CharacterEvent += delegate { Console.WriteLine($"LightningStaff is used\n" +
                                                                  $"Current HP: {target.CurrentHP}"); };
        }

        public override void Use(MagicCharacter holder, Character target, uint power)
        {
            if (target.CurrentHP < power || power > Power)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use LightningStaff!"); };
                return;
            }

            target.CurrentHP -= power;
            Power -= power;
            holder.CharacterEvent += delegate { Console.WriteLine($"LightningStaff is used\n" +
                                                                  $"Current LightningStaff Power: {Power}"); };
            target.CharacterEvent += delegate { Console.WriteLine($"LightningStaff is used\n" +
                                                                  $"Current HP: {target.CurrentHP}"); };
        }

        public override void Use(MagicCharacter holder, MagicCharacter target, uint power)
        {
            if (target.CurrentHP < power || power > Power)
            {
                holder.CharacterEvent += delegate { Console.WriteLine("Can't use LightningStaff!"); };
                return;
            }

            target.CurrentHP -= power;
            Power -= power;
            holder.CharacterEvent += delegate { Console.WriteLine($"LightningStaff is used\n" +
                                                                  $"Current LightningStaff Power: {Power}"); };
            target.CharacterEvent += delegate { Console.WriteLine($"LightningStaff is used\n" +
                                                                  $"Current HP: {target.CurrentHP}"); };
        }

        public override string ToString()
        {
            return $"LightningStaff: {Power}";
        }
    }
}