using System;

namespace HeistPT2
{
  public class Hackers : IRobbers
  {
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int intPercentageCut { get; set; }
    public void PerformSkill(Bank bank)
    {
      bank.AlarmScore -= SkillLevel;

      if (SkillLevel == 50)
      {
        bank.AlarmScore -= 50;
      }

      Console.Write($"{Name} is picking the vault! Security has been decreased by {bank.AlarmScore} points");

      if (bank.AlarmScore <= 0)
      {
        Console.WriteLine($"{Name} has cut the alarm! 💰💰💰💰💰");
      }
    }
  }
}