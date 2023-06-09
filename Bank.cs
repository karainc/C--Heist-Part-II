using System;

public class Bank

{
    public int AlarmScore {get; set;}
    public int CashOnHand {get; set;}

    public int VaultScore {get; set;}

    public int SecurityGaurdScore {get; set;}

    public bool IsSecure {get {
        if( AlarmScore > 0 || VaultScore > 0 || SecurityGaurdScore > 0 )
        {
            return true ;
        }
        else {
            return false;
        }
    }}
    public void Report() {

    List<KeyValuePair<string, int>> scores = new List<KeyValuePair<string, int>>();
     scores.Add(new KeyValuePair<string, int>("Alarm Score" , AlarmScore));
     scores.Add(new KeyValuePair<string, int>("Vault Score" , VaultScore));
     scores.Add(new KeyValuePair<string, int>("Security Gaurd Score", SecurityGaurdScore));
  
        var sortedList = scores.OrderBy(x => x.Value).ToList();

            Console.WriteLine("Here's what we scoped out");
            Console.WriteLine($"The most secure system is the {sortedList[0].Key} {sortedList[0].Value}");

            Console.WriteLine($"The least secure system is the {sortedList[2].Key}{sortedList[2].Value}");

    }
}