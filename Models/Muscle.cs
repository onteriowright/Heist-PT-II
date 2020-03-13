using System;

namespace HeistPT2
{
  public class Muscle : IRobbers
  {
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public string Speciality { get; set; }
    public int IntPercentageCut { get; set; }
    public void PerformSkill(Bank bank)
    {
      bank.SecurityGuardScore -= SkillLevel;

      Console.Write($"{Name} is picking the vault! Decreased security {bank.SecurityGuardScore} points");

      if (bank.SecurityGuardScore <= 0)
      {
        Console.WriteLine($"{Name} has entered the vault! 💰💰💰💰💰");
      }
    }
  }
}