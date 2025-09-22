using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private string name;
    public string Name
    {
        get => name;
        set => name = (string.IsNullOrEmpty(value)) ? "Unknown Name" : value;
    }

    private int hunger;
    public int Hunger
    {
        get => hunger;
        private set => hunger = (value < 0) ? 0 : (value > 50) ? 50 : value;
    }

    private int happiness;
    public int Happiness
    {
        get => happiness;
        private set => happiness = (value < 0) ? 0 : (value > 50) ? 50 : value;
    }

    // Constructor
    public virtual void Init(string newName, int newHunger, int newHappiness)
    {

        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
    }

    // Method
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

    public virtual void MakeSound()
    {
        AdjustHappiness(10);
        Debug.Log($"{Name} makes the sound. Happiness increased by 10.");
    }

    public virtual void Feed(int amountFood)
    {
        AdjustHunger(Hunger -= amountFood * 4);
        AdjustHappiness(Happiness += amountFood * 4);
        Debug.Log($"{Name} ate food at the amount of {amountFood}.");
    }

    public virtual void GetStatus() => Debug.Log($"Status of {Name}: Hunger = {Hunger}, Happiness = {Happiness}");
}