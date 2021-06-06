using System;
using Game.Enums;

namespace Game.Classes.Artifacts
{
    public class LivingWaterBottle : Artifact
    {
        private BottleType Type { get; set; }

        public LivingWaterBottle(BottleType type) : base(false, 0)
        {
            Type = type;
        }

        private int GetBottleSize()
        {
            return Type switch
            {
                BottleType.Big => 50,
                BottleType.Medium => 25,
                _ => 10
            };
        }
        
        public override void Use(Character holder, uint power = 0)
        {
            if (holder.CurrentHP < holder.MaxHP)
            {
                for (int i = 1; i <= GetBottleSize(); i++)
                {
                    if(holder.CurrentHP >= holder.MaxHP)
                        break;
                    holder.CurrentHP++;
                }
                holder.CharacterEvent += delegate { Console.WriteLine($"{Type} Living water bottle is used\n" +
                                                                      $"Current HP: {holder.CurrentHP}"); };
                holder.Inventory.Remove(this);
                return;
            }
            holder.CharacterEvent += delegate { Console.WriteLine($" You can't use living water bottle"); };
        }

        public override void Use(MagicCharacter holder, uint power = 0)
        {
            if (holder.CurrentHP < holder.MaxHP)
            {
                for (int i = 1; i <= GetBottleSize(); i++)
                {
                    if(holder.CurrentHP >= holder.MaxHP)
                        break;
                    holder.CurrentHP++;
                }
                holder.CharacterEvent += delegate { Console.WriteLine($"{Type} Living water bottle is used\n" +
                                                                      $"Current HP: {holder.CurrentHP}"); };
                holder.Inventory.Remove(this);
                return;
            }
            holder.CharacterEvent += delegate { Console.WriteLine($" You can't use living water bottle"); };
        }
        
        public override string ToString()
        {
            return $"{Type} LivingWaterBottle";
        }
    }
}