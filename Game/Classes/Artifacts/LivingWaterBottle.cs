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

        public override void Use(Character holder, uint power = 0)
        {
            holder.CharacterEvent += delegate { Console.WriteLine($"Living water bottle is used" +
                                                                  $"Current HP: {holder.CurrentHP}"); };
            
            //GC.SuppressFinalize(this);
        }
        
        
    }
}