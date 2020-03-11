using System;

namespace HeistPT2
{
  public class LockSpecialist : IRobbers
  {
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int intPercentageCut { get; set; }
    public void PerformSkill(Bank bank)
    {
      bank.VaultScore -= SkillLevel;

      Console.Write($"{Name} is picking the vault! Decreased security {bank.VaultScore} points");

      if (bank.VaultScore <= 0)
      {
        Console.WriteLine($"{Name} has entered the vault! 💰💰💰💰💰");
      }

    }
  }
}