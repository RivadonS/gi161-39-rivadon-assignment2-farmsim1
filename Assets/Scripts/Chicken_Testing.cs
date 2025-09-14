using UnityEngine;

public class Chicken_Testing
{
    //Properties with automatic getters and setters
    public string Name { get; set; }
    public int Hunger { get; set; }
    public int Happiness { get; set; }
    public int Eggs { get; set; }

    //Constructors
    public Chicken_Testing(string newName, int newHunger, int newHappiness, int newEggs)
    {
        Name = string.IsNullOrEmpty(newName) ? "Unknown Chicken Name" : newName;
        Hunger = Mathf.Clamp(newHunger, 0, 50);
        Happiness = Mathf.Clamp(newHappiness, 0, 50);
        Eggs = Mathf.Max(0, newEggs);
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

    public void MakeSound()
    {
        // This method was empty, so a simple sound is added
        Debug.Log($"{Name} says 'Cluck!'");
    }

    public string Feed(string feed)
    {
        AdjustHunger(-10);
        AdjustHappiness(10);
        Debug.Log($"{Name} ate some {feed}. Hunger decreased and happiness increased.");
        return $"The chicken ate {feed}.";
    }

    public void GetStatus() => Debug.Log($"Status of {Name}: Hunger = {Hunger}, Happiness = {Happiness}, Eggs = {Eggs}");

    public void Sleep()
    {
        AdjustHunger(5);
        AdjustHappiness(10);
        Debug.Log($"{Name} is sleeping. Hunger increased slightly and happiness increased.");
    }
}
