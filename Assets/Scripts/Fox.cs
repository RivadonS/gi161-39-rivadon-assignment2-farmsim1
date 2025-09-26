using UnityEngine;

public class Fox : Animal
{
    //Constructor
    public override void Init(string newName)
    {
        base.Init(newName);
        PreferedFood = FoodType.Apple;
    }

    //Method
    public override void MakeSound()
    {
        AdjustHappiness(10);
        Debug.Log($"{Name} makes the sound. Happiness increased by 10.");
        Debug.Log($"{Name} barking.");
    }

    public override void GetStatus()
    {
        base.GetStatus();
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
