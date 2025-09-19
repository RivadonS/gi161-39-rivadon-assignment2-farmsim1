using UnityEngine;

public class Chicken : Animal
{
    private int eggs;
    public int Eggs
    {
        get => eggs;
        set => eggs = (value < 0) ? 0 : value;
    }

    //Constructor
    public void Init(string newName, int newHunger, int newHappiness, int newEggs)
    {
        base.Init(newName, newHunger, newHappiness);
        Eggs = newEggs;
    }

    //Method
    public override void MakeSound()
    {
        Debug.Log($"{Name} clucking.");
        base.MakeSound();
    }

    public void Sleep()
    {
        AdjustHunger(5);
        AdjustHappiness(10);
        Debug.Log($"{Name} is sleeping. Hunger increased slightly and happiness increased.");
    }

    public override void GetStatus()
    {
        base.GetStatus();
        Debug.Log($"Name: {Name}, Eggs: {Eggs}");
    }

    public void Feeds(string foodTypes, int amountFood)
    {
        string FoodTypes = foodTypes;
        Debug.Log($"{Name} is eating {FoodTypes}");
        base.Feed(amountFood);
    }
}