public class LockSpecialist : IRobber
{
        public LockSpecialist(string name, int skill, int percent){
        Name = name;
        SkillLevel = skill;
        PercentageCut = percent;
    }
    public string Name {get; set;}

    public int SkillLevel {get; set;}
    public int PercentageCut {get; set;}

     public string Type {get;} = "Lock Specialist";

    public void PerformSkill(Bank bank)
{
    bank.VaultScore = bank.VaultScore - SkillLevel;

    Console.WriteLine($"{Name} is cracking the vault. Decrease security {SkillLevel} points.");

    if(bank.VaultScore <= 0){
        Console.WriteLine($"{Name} has cracked the vault.");
    }
}
}