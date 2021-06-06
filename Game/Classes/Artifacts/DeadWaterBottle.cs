using System;
using Game.Enums;

namespace Game.Classes.Artifacts
{
    public class DeadWaterBottle : Artifact
    {
         private BottleType Type { get; set; }
        
                public DeadWaterBottle(BottleType type) : base(false, 0)
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

                public override void Use(MagicCharacter holder, uint power = 0)
                {
                    if (holder.CurrentMP < holder.MaxMP)
                    {
                        for (int i = 1; i <= GetBottleSize(); i++)
                        {
                            if(holder.CurrentMP >= holder.MaxMP)
                                break;
                            holder.CurrentMP++;
                        }
                        holder.CharacterEvent += delegate { Console.WriteLine($"{Type} Dead water bottle is used\n" +
                                                                              $"Current MP: {holder.CurrentMP}"); };
                        holder.Inventory.Remove(this);
                        return;
                    }
                    holder.CharacterEvent += delegate { Console.WriteLine($" You can't use Dead water bottle"); };
                }
                
                public override string ToString()
                {
                    return $"{Type} DeadWaterBottle";
                }
    }
}