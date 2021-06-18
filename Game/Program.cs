using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Game.Classes;
using Game.Classes.Artifacts;
using Game.Enums;

namespace Game
{
    public static class Program
    {
        public static int id;
        private static void Main()
        {
            MagicCharacter npc = new MagicCharacter("npc", true, true,
                Race.Human, Sex.Male, 20, 100, 20, 20, 100, 20);
            MagicCharacter hero = new MagicCharacter("Misha", true, true,
                Race.Elf, Sex.Male, 19, 100, 100, 20, 100, 100);
            Character villain = new Character("DedHook", true, true,
                Race.Orc, Sex.Male, 100, 100, 100, 100);
            string select = "";
            Console.WriteLine(
                $"Добро пожаловать в интерактивную ролевую игру, вы будете играть за персонажа:\n\n{hero.ShowBase()}\n\n" +
                $"Либо можете создать своего собственного персонажа:\n" +
                $"\tПропустить - Оставить текущего\n" +
                $"\t1 - Создать нового\n");
            select = Console.ReadLine();
            
            
            if (select == "1")//Создание персонажа
            {
                string tempName = "Misha";
                Race tempRace;
                Sex tempSex;
                uint tempAge;
                
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Вы будете играть за магического персонажа: ");
                Console.WriteLine("Выберите рассу вашему персонажу:\n" +
                                  "\t1 - Человек\n" +
                                  "\t2 - Эльф\n" +
                                  "\t3 - Гном\n" +
                                  "\t4 - Орк\n" +
                                  "\t5 - Гоблин");
                select = Console.ReadLine() ?? String.Empty;
                switch (@select)
                {
                    case "1":
                        tempRace = Race.Human;
                        break;
                    case "2":
                        tempRace = Race.Elf;
                        break;
                    case "3":
                        tempRace = Race.Dwarf;
                        break;
                    case "4":
                        tempRace = Race.Orc;
                        break;
                    case "5":
                        tempRace = Race.Goblin;
                        break;
                    default:
                        Console.WriteLine("\nВы не выбрали рассу поэтому будет выбрана расса Человек!\n");
                        tempRace = Race.Human;
                        break;
                }
                Thread.Sleep(2000);
                Console.Clear();
                
                Console.WriteLine("Выберите пол вашему персонажу:\n" +
                                  "\t1 - Мужчина\n" +
                                  "\t2 - Женщина"); 
                select = Console.ReadLine() ?? String.Empty;
                switch (@select)
                {
                    case "1":
                        tempSex = Sex.Male;
                        break;
                    case "2":
                        tempSex = Sex.Female;
                        break;
                    default:
                        Console.WriteLine("\nВы не выбрали пол поэтому будет выбран Мужской пол!\n");
                        tempSex = Sex.Male;
                        break;
                }
                Thread.Sleep(2000);
                Console.Clear();
                
                Console.Write("Укажите возраст вашего персонажа: "); 
                select = Console.ReadLine() ?? String.Empty;
                if (!uint.TryParse(select, out tempAge))
                {
                    Console.WriteLine("Вы не указали возраст персонажа поэтому будет выбран 19!");
                    tempAge = 19;
                }
                Thread.Sleep(2000);
                Console.Clear();
                
                Console.Write("Выберите имя вашему персонажу: "); 
                select = Console.ReadLine() ?? String.Empty;
                if (select == String.Empty)
                    Console.WriteLine("Вы не указали имя персонажа поэтому будет выбрано Misha!");
                else
                    tempName = select;
                Thread.Sleep(2000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                hero = new MagicCharacter(tempName, true, true,
                    tempRace, tempSex, tempAge, 100, 100, 0, 100, 100);
                
            }
            
            Console.Clear();
            Console.WriteLine($"Вы будете играть за персонажа:\n\n{hero.ShowBase()}\n\n" +
                              $"Вам предстоит период обучения после которого вы должны будете одолеть злодея: {villain.Name}\n\n" +
                              $"Начать............");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            
            Console.Clear();//Период обучения
            hero.Abilities = new List<Spell>()
            {
                new Heal(),
                new AddHP(),
                new Antidote()
            };
            Console.WriteLine($"Вы появляетесь в начале своего пути обучения с базовым набором способностей:\n");
            hero.ShowAbilities();
            Console.WriteLine($"\nТак же вы можете выбрать 1 из начальных артефактов:\n" +
                              $"\t1 - Средняя бутылка живой воды\n" +
                              $"\t2 - Глаз василиска\n" +
                              $"\t3 - Ядовитые зубы\n");
            select = Console.ReadLine() ?? String.Empty;
            switch (@select)
            {
                case "1":
                    hero.TakeArtifact(new LivingWaterBottle(BottleType.Medium));
                    break;
                case "2":
                    hero.TakeArtifact(new BasiliskEye());
                    break;
                case "3":
                    hero.TakeArtifact(new PoisonousPatch());
                    break;
                default:
                    Console.WriteLine("Вы не выбрали начальный артифакт поэтому получается среднюю бутылку с живой водой!");
                    hero.TakeArtifact(new LivingWaterBottle(BottleType.Medium));
                    break;
            }
            
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Вы идете дальше по тропинке и видите человека который отравлен\nи ему нужна ваша помощь\n" +
                              "Использовать заклятие антидота на него? или нет\n" +
                              "\t1 - Да\n" +
                              "\t2 - Нет\n");
            select = Console.ReadLine() ?? String.Empty;
            switch (@select)
            {
                case "1":
                    npc.State = State.Poisoned;
                    hero.Abilities.Find(i => i.ToString() == new Antidote().ToString())?.Cast(hero, npc);
                    break;
                default:
                    var temp = new PoisonousPatch();
                    temp.Use(npc, hero, 20);
                    Console.WriteLine("Вы решили не помогать человеку и его состояние ухудшилось, но к сожалению для вас\n" +
                                      "он успел использовать на вас отравление!\n\n" +
                                      "Ваше текущее здоровье и состояние:\n" +
                                      $"\t {hero.CurrentHP} HP {hero.State}");
                    Thread.Sleep(4000);
                    Console.Clear();
                    Console.WriteLine($"После отравления вы использовали на себя заклятие антидота");
                    hero.Abilities.Find(i => i.ToString() == new Antidote().ToString())?.Cast(hero);
                    Console.WriteLine($"Ваше состояние изменилось на {hero.State}");
                    break;
            }
            
            Console.WriteLine("\nВы идете дальше и неизвестный человек дает вам Посох Молний, принять его?:\n"+
                              "\t1 - Да\n" +
                              "\t2 - Нет\n");
            select = Console.ReadLine() ?? String.Empty;
            switch (@select)
            {
                case "1":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    npc.TakeArtifact(new LightningStaff());
                    npc.GiveArtifact(hero, npc.Inventory.Find(
                        i => i.ToString() == new LightningStaff().ToString()));
                    Console.WriteLine("Человек который дал вам артифакт был гланым злодеем, в результате чего посох оказался заколдован,\n" +
                                      "Вы решили его использовать и умерли :((((((((");
                    Thread.Sleep(7000);
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine("Игра окончена!!");
                    Thread.Sleep(4000);
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Вы решили не брать посох после чего персонаж вас отоковал и им оказался главный злодей\n" +
                                      "Но вы не растерялись и использовали свое самое смертельное заклинание которое его убило,\n" +
                                      "Но заклинание так же погубило и вас((((((((((");
                    Thread.Sleep(7000);
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine("Игра окончена!!");
                    Thread.Sleep(4000);
                    break;
            }
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            hero.OnCharacterEvent();
            Console.ReadLine();
        }
    }
}