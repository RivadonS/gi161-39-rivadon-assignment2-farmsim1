using UnityEngine;

public class Chicken
{
    //Property
    private string name;
    public string Name { 
        get => name; 
        set => name = (string.IsNullOrEmpty(value)) ? "Unknown Chicken Name" : value; 
    }

    private int hunger;
    public int Hunger
    {
        get => hunger;
        set => hunger = (value < 0) ? 0 : (value > 50) ? 50 : value;
    }

    private int happiness;
    public int Happiness
    {
        get => happiness;
        set => happiness = (value < 0) ? 0 : (value > 50) ? 50 : value;
    }

    private int eggs;
    public int Eggs
    {
        get => eggs;
        set => eggs = (value < 0) ? 0 : value;
    }

    //Constructor
    public Chicken(string newName, int newHunger, int newHappiness, int newEggs)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
        Eggs = newEggs;
    }

    //Method
    public int AdjustHunger(int amount)
    {
        Hunger += amount;
        Debug.Log($"{Name}'s hunger is now: {Hunger}");
        return Hunger;
    }

    public int AdjustHappiness(int amount)
    {
        Happiness += amount;
        Debug.Log($"{Name}'s happiness is now: {Happiness}");
        return Happiness;
    }

    public void MakeSound()
    {

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
