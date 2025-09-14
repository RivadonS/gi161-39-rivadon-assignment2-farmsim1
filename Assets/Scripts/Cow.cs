using UnityEngine;

public class Cow
{
    private string name;
    public string Name
    {
        get => name;
        set => name = (string.IsNullOrEmpty(value)) ? "Unknown Cow Name" : value;
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

    private float milk;
    public float Milk
    {
        get => milk;
        set => milk = (value < 0) ? 0 : value;
    }

    //Constructor
    public Cow(string newName, int newHunger, int newHappiness, float newMilk)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
        Milk = newMilk;
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
        AdjustHappiness(10);
        Debug.Log($"{Name} says 'Moo!'. Happiness increased by 10.");
    }

    public string Feed(string feed)
    {
        AdjustHunger(-10);
        AdjustHappiness(10);
        Debug.Log($"{Name} ate some {feed}. Hunger decreased and happiness increased.");
        return $"The chicken ate {feed}.";
    }

    public void GetStatus() => Debug.Log($"Status of {Name}: Hunger = {Hunger}, Happiness = {Happiness}, Milk = {Milk}");

    public void Moo() => MakeSound();
}
