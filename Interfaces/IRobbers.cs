using System;

namespace HeistPT2
{
  public interface IRobbers
  {
    string Name { get; set; }
    int SkillLevel { get; set; }
    int intPercentageCut { get; set; }
    void PerformSkill(Bank bank);

  }
}