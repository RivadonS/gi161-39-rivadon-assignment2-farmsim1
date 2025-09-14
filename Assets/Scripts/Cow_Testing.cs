using UnityEngine;

public class Cow_Testing
{
    //Properties
    public string Name { get; set; }
    public int Hunger { get; set; }
    public int Happiness { get; set; }
    public float Milk { get; set; }

    //Constructor
    public Cow_Testing(string newName, int newHunger, int newHappiness, float newMilk)
    {
        Name = string.IsNullOrEmpty(newName) ? "Unknown Cow Name" : newName;
        Hunger = Mathf.Clamp(newHunger, 0, 50);
        Happiness = Mathf.Clamp(newHappiness, 0, 50);
        Milk = Mathf.Max(0, newMilk);
    }

    //Methods
    public int AdjustHunger(int amount)
    {
        Hunger = Mathf.Clamp(Hunger + amount, 0, 50);
        Debug.Log($"{Name}'s hunger is now: {Hunger}");
        return Hunger;
    }

    public int AdjustHappiness(int amount)
    {
        Happiness = Mathf.Clamp(Happiness + amount, 0, 50);
        Debug.Log($"{Name}'s happiness is now: {Happiness}");
        return Happiness;
    }

    public void MakeSound() => AdjustHappiness(10);

    public string Feed(string feed)
    {
        AdjustHunger(-10);
        AdjustHappiness(10);
        Debug.Log($"{Name} ate some {feed}. Hunger decreased and happiness increased.");
        return $"The cow ate {feed}.";
    }

    public void GetStatus() => Debug.Log($"Status of {Name}: Hunger = {Hunger}, Happiness = {Happiness}, Milk = {Milk}");

    public void Moo()
    {
        MakeSound();
        Debug.Log($"{Name} says 'Moo!'. Happiness increased by 10.");
    }
}
