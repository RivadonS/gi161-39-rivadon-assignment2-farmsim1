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
    public override void Init(string newName)
    {
        base.Init(newName);
        PreferedFood = FoodType.Grain;
    }

    //Method
    public override void MakeSound()
    {
        AdjustHappiness(10);
        Debug.Log($"{Name} makes the sound. Happiness increased by 10.");
        Debug.Log($"{Name} clucking.");
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

    public void Feeds(FoodType preferedFood, int amountFood)
    {
        switch (preferedFood)
        {
            case FoodType.RottenFood:
                AdjustHunger(0);
                AdjustHappiness(-20);
                Debug.Log($"{Name} ate RottenFood. Hunger unchanged, Happiness decreased by 20. Latest Happiness: {Happiness}");
                break;
            case FoodType.AnimalFood:
                base.Feed(amountFood);
                break;
            default:
                AdjustHunger(-amountFood);
                AdjustHappiness(15);
                Debug.Log($"{Name} is happy because eating {preferedFood} in amount of {amountFood}." +
                    $"Latest Happiness: {Happiness}");
                break;
        }
    }

    public override void Produce()
    {
        throw new System.NotImplementedException();
    }
}