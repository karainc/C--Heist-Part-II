public class Hacker : IRobber
{
    public Hacker(string name, int skill, int percent){
        Name = name;
        SkillLevel = skill;
        PercentageCut = percent;
    }
    public string Name {get; set;}

    public int SkillLevel {get; set;}
    public int PercentageCut {get; set;}

    public string Type {get;} = "Hacker";

    public void PerformSkill(Bank bank)
{
    bank.AlarmScore = bank.AlarmScore - SkillLevel;

    Console.WriteLine($"{Name} is hacking the alarm system. Decrease security {SkillLevel} points.");

    if(bank.AlarmScore <= 0){
        Console.WriteLine($"{Name} has disabled the alarm system");
    }
}
}