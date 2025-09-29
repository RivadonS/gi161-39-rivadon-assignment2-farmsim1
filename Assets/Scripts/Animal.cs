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
    private int minHunger = 0;
    private int maxHunger = 100;
    public int Hunger { get; private set; }
    //private int happiness;
    private int minHappiness = 0;
    private int maxHappiness = 100;
    public int Happiness { get; private set; }
    public FoodType PreferedFood { get; protected set; }
    // Constructor
    public void Init(string newName)
    {
        Name = newName;
        Hunger = 50;
        Happiness = 50;
    }
    // Method
    public int AdjustHunger(int amount)
    {
        //Hunger += amount;
        Hunger = Mathf.Clamp(Hunger + amount, minHunger, maxHunger);
        Debug.Log($"{Name}'s hunger is now: {Hunger}");
        return Hunger;
    }
    public int AdjustHappiness(int amount)
    {
        //Happiness += amount;
        Happiness = Mathf.Clamp(Happiness + amount, minHappiness, maxHappiness);
        Debug.Log($"{Name}'s happiness is now: {Happiness}");
        return Happiness;
    }
    public virtual void Feed(int amountFood)
    {
        AdjustHunger(-amountFood);
        AdjustHappiness(amountFood / 2);
        Debug.Log($"{Name} ate food at the amount of {amountFood}.");
    }
    public virtual void GetStatus() => Debug.Log($"{Name} --> Hunger = {Hunger}, Happiness = {Happiness}, PreferedFood = {PreferedFood}");
    public abstract void MakeSound();
    public abstract string Produce();
}