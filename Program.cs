using System;
using System.Collections.Generic;

namespace HeistPT2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();

            var rolodex = new List<IRobbers>();

            var Onterio = new Hackers()
            {
                Name = "Onterio",
                SkillLevel = 50,
                intPercentageCut = 50
            };

            var Luis = new LockSpecialist()
            {
                Name = "Luis",
                SkillLevel = 20,
                intPercentageCut = 20
            };

            var Adrian = new Muscle()
            {
                Name = "Adrian",
                SkillLevel = 45,
                intPercentageCut = 30
            };

            rolodex.Add(Onterio);
            rolodex.Add(Luis);
            rolodex.Add(Adrian);

            while (true)
            {
                Console.WriteLine("Welcome! Let's plan a heist...");
                Console.WriteLine($"You currently have {rolodex.Count} members in your crew!");
                Console.Write("Enter crew member name: ");
                var crewMemberName = Console.ReadLine();
                if (crewMemberName == "")
                {
                    Console.WriteLine($"You now have {rolodex.Count} members in your crew!");
                    foreach (var name in rolodex)
                    {
                        Console.WriteLine($"{name.Name}");
                    }
                    Console.WriteLine("Closing app!...👋👋👋");
                    break;
                }
                else
                {
                    Console.Write($"Should {crewMemberName} be a Hacker (Disables alarms), Muscle (Disarms guards), or Lock Specialist (Cracks vaults)? ");

                    string crewMemberSpeciality;

                    while (true)
                    {

                        crewMemberSpeciality = Console.ReadLine().ToLower();
                        if (crewMemberSpeciality == "hacker")
                        {
                            var newHacker = new Hackers()
                            {
                            Name = crewMemberName,
                            };

                            Console.Write($"Enter {crewMemberName} skill level: ");
                            newHacker.SkillLevel = int.Parse(Console.ReadLine());

                            Console.Write($"Enter {crewMemberName} cut: ");
                            newHacker.intPercentageCut = int.Parse(Console.ReadLine());
                            rolodex.Add(newHacker);

                            Console.Clear();
                            break;

                        }

                        else if (crewMemberSpeciality == "muscle")
                        {
                            var newMuscle = new Muscle()
                            {
                            Name = crewMemberName,
                            };

                            Console.Write($"Enter {crewMemberName} skill level: ");
                            newMuscle.SkillLevel = int.Parse(Console.ReadLine());

                            Console.Write("Enter members cut: ");
                            newMuscle.intPercentageCut = int.Parse(Console.ReadLine());
                            rolodex.Add(newMuscle);
                            break;

                        }

                        else if (crewMemberSpeciality == "lock specialist")
                        {
                            var lockSpecialist = new LockSpecialist()
                            {
                            Name = crewMemberName,
                            };

                            Console.Write($"Enter {crewMemberName} skill level: ");
                            lockSpecialist.SkillLevel = int.Parse(Console.ReadLine());

                            Console.Write("Enter members cut: ");
                            lockSpecialist.intPercentageCut = int.Parse(Console.ReadLine());
                            rolodex.Add(lockSpecialist);
                            break;

                        }

                        else
                        {
                            Console.WriteLine($"Not a valid entry! Please enter a speciality!");
                        };

                    }
                }
            }
        }
    }
}