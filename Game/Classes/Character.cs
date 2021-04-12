using System;
using Game.Enums;

namespace Game.Classes
{
    public class Character : IComparable<Character>
    {
        protected int id;
        private string name;
        private State state;
        private bool currentTalkAbillity;
        private bool currentWalkAbillity;
        private Race race;
        private Sex sex;
        private uint age;
        private uint maxHP;
        private uint currentHP;
        private uint experience;

        public uint CurrentHP
        {
            get => currentHP;
            set
            {
                if (value <= MaxHP)
                {
                    currentHP = value;
                    State = 0;
                }
                else
                {
                    throw new ArgumentException();
                }
                State = 0;
            }
        }
        public uint MaxHP
        {
            get => maxHP;
            set => maxHP = value;
        }
        public int Id => id;
        public string Name => name;
        public State State
        {
            get => state;
            set
            {
                if (CurrentHP * 100 / MaxHP < 10)
                    state = State.Weakened;
                if (CurrentHP * 100 / MaxHP >= 10)
                    state = State.Normal;
                if (CurrentHP == 0)
                    state = State.Dead;
                else
                {
                    state = value;
                }
            }
        }
        public bool CurrentTalkAbillity
        {
            get => currentTalkAbillity;
            set => currentTalkAbillity = value;
        }
        public bool CurrentWalkAbillity
        {
            get => currentWalkAbillity;
            set => currentWalkAbillity = value;
        }
        public Race Race => race;
        public Sex Sex => sex;
        public uint Age
        {
            get => age;
            set => age = value;
        }
        public uint Experience
        {
            get => experience;
            set => experience = value;
        }

        public delegate void CharacterHandler();

        public event CharacterHandler CharacterEvent;
        public Character(string name, bool currentTalkAbillity, bool currentWalkAbillity, Race race, Sex sex, uint age,
            uint maxHp, uint currentHp, uint experience)
        {
            id = Program.id;
            Program.id += 1;
            this.name = name;
            CurrentTalkAbillity = currentTalkAbillity;
            CurrentWalkAbillity = currentWalkAbillity;
            this.race = race;
            this.sex = sex;
            Age = age;
            MaxHP = maxHp;
            CurrentHP = currentHp;
            Experience = experience;
            CharacterEvent += delegate { Console.WriteLine($"Character {Name} ({Race}) created!");};
        }
        
        public int CompareTo(Character obj)
        {
            if (Experience > obj.Experience)
                return 1;
            if (Experience < obj.Experience)
                return -1;
            return 0;
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
                   $"Experience: {Experience}";
        }
        public void OnCharacterEvent()
        {
            CharacterEvent?.Invoke();
        }
    }
}