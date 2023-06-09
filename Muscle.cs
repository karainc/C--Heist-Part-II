public class Muscle : IRobber
{
        public Muscle(string name, int skill, int percent){
        Name = name;
        SkillLevel = skill;
        PercentageCut = percent;
    }
    public string Name {get; set;}

    public int SkillLevel {get; set;}
    public int PercentageCut {get; set;}

     public string Type {get;} = "Muscle";

    public void PerformSkill(Bank bank)
{
    bank.SecurityGaurdScore = bank.SecurityGaurdScore - SkillLevel;

    Console.WriteLine($"{Name} is handling the security gaurds. Decrease security {SkillLevel} points.");

    if(bank.SecurityGaurdScore <= 0){
        Console.WriteLine($"{Name} has taken out the gaurds.");
    }
}
}