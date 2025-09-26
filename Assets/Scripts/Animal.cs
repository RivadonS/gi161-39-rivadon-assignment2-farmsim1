using UnityEngine;

public enum FoodType
{
    Hay,
    Grain,
    Apple,
    RottenFood,
    AnimalFood
}

public abstract class Animal : MonoBehaviour
{
    private string name;
    public string Name
    {
        get => name;
        set => name = (string.IsNullOrEmpty(value)) ? "Unknown Name" : value;
    }

    //private int hunger;
    private int maxHunger = 100;
    public int Hunger { get; private set; }

    //private int happiness;
    private int maxHappiness = 100;
    public int Happiness { get; private set; }

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
        //Hunger += amount;
        Hunger = Mathf.Clamp(Hunger + amount, 0, maxHunger);
        Debug.Log($"{Name}'s hunger is now: {Hunger}");
        return Hunger;
    }

    public int AdjustHappiness(int amount)
    {
        //Happiness += amount;
        Happiness = Mathf.Clamp(Happiness + amount, 0, maxHappiness);
        Debug.Log($"{Name}'s happiness is now: {Happiness}");
        return Happiness;
    }

    public virtual void Feed(int amountFood)
    {
        AdjustHunger(Hunger -= amountFood * 4);
        AdjustHappiness(Happiness += amountFood / 2);
        Debug.Log($"{Name} ate food at the amount of {amountFood}.");
    }

    public virtual void GetStatus() => Debug.Log($"Status of {Name}: Hunger = {Hunger}, Happiness = {Happiness}");

    public abstract void MakeSound();

    public abstract void Produce();
}