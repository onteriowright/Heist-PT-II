using System;
using System.Collections.Generic;

namespace HeistPT2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rolodex = new List<IRobbers>();

            var Onterio = new Hackers()
            {
                Name = "Onterio",
                SkillLevel = 50,
                IntPercentageCut = 50
            };

            var Luis = new LockSpecialist()
            {
                Name = "Luis",
                SkillLevel = 20,
                IntPercentageCut = 20
            };

            var Akemo = new Muscle()
            {
                Name = "Akemo",
                SkillLevel = 45,
                IntPercentageCut = 30
            };

            var Danyeal = new Muscle()
            {
                Name = "Danyeal",
                SkillLevel = 50,
                IntPercentageCut = 45
            };

            rolodex.Add(Onterio);
            rolodex.Add(Luis);
            rolodex.Add(Akemo);
            rolodex.Add(Danyeal);

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

                    break;
                }
                else
                {
                    Console.Write($"Should {crewMemberName} be a Hacker (Disables alarms), Muscle (Disarms guards), or Lock Specialist (Cracks vaults)? ");

                    string crewMemberSpeciality;
                    int skillLevel = 0;
                    int intPercentageCut = 0;

                    while (true)
                    {

                        crewMemberSpeciality = Console.ReadLine().ToLower();
                        if (crewMemberSpeciality == "hacker")
                        {
                            Console.Write($"Enter {crewMemberName}'s skill level: ");
                            skillLevel = int.Parse(Console.ReadLine());

                            Console.Write($"Enter {crewMemberName}'s cut: ");
                            intPercentageCut = int.Parse(Console.ReadLine());

                            var newHacker = new Hackers()
                            {
                                Name = crewMemberName,
                                Speciality = crewMemberSpeciality,
                                SkillLevel = skillLevel,
                                IntPercentageCut = intPercentageCut
                            };

                            rolodex.Add(newHacker);

                            Console.Clear();
                            break;
                        }

                        else if (crewMemberSpeciality == "muscle")
                        {
                            Console.Write($"Enter {crewMemberName}'s skill level: ");
                            skillLevel = int.Parse(Console.ReadLine());

                            Console.Write($"Enter {crewMemberName}'s cut: ");
                            intPercentageCut = int.Parse(Console.ReadLine());

                            var newMuscle = new Muscle()
                            {
                                Name = crewMemberName,
                                Speciality = crewMemberSpeciality,
                                SkillLevel = skillLevel,
                                IntPercentageCut = intPercentageCut
                            };

                            rolodex.Add(newMuscle);

                            Console.Clear();
                            break;
                        }

                        else if (crewMemberSpeciality == "lock specialist")
                        {
                            Console.Write($"Enter {crewMemberName}'s skill level: ");
                            skillLevel = int.Parse(Console.ReadLine());

                            Console.Write($"Enter {crewMemberName}'s cut: ");
                            intPercentageCut = int.Parse(Console.ReadLine());

                            var lockSpecialist = new LockSpecialist()
                            {
                                Name = crewMemberName,
                                Speciality = crewMemberSpeciality,
                                SkillLevel = skillLevel,
                                IntPercentageCut = intPercentageCut
                            };

                            rolodex.Add(lockSpecialist);

                            Console.Clear();
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