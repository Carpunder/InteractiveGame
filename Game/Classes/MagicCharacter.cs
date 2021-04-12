using Game.Enums;

namespace Game.Classes
{
    public class MagicCharacter : Character
    {
        private uint maxMP;
        private uint currentMP;
        
        public uint MaxMP
        {
            get => maxMP;
            set => maxMP = value;
        }
        public uint CurrentMP
        {
            get => currentMP;
            set
            {
                if (value <= MaxMP)
                    currentMP = value;
            }
        }

        public MagicCharacter(string name, bool currentTalkAbillity, bool currentWalkAbillity, Race race,
            Sex sex, uint age, uint maxHp, uint currentHp, uint experience, uint maxMp, uint currentMp)
            : base(name, currentTalkAbillity, currentWalkAbillity, race, sex, age, maxHp, currentHp, experience)
        {
            id = Program.id;
            Program.id += 1;
            MaxMP = maxMp;
            CurrentMP = currentMp;
        }
        
        public override string ToString()
        {
            return $"Id: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"State: {State}\n" +
                   $"Current Talk Ability: {CurrentTalkAbillity}\n" +
                   $"Current Walk Ability: {CurrentWalkAbillity}\n" +
                   $"Race: {Race}\n" +
                   $"Sex: {Sex}\n"+
                   $"Age: {Age}\n"+
                   $"Max HP: {MaxHP}\n" +
                   $"Current HP {CurrentHP}\n" +
                   $"Max MP: {MaxMP}\n" +
                   $"Current MP {CurrentMP}\n" +
                   $"Experience: {Experience}";
        }
    }
}