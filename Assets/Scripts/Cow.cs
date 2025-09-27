using UnityEngine;

public class Cow : Animal
{
    private float milk;
    public float Milk
    {
        get => milk;
        private set => milk = (value < 0) ? 0 : value;
    }

    //Constructor
    public void InitCow(string newName)
    {
        base.Init(newName);
        PreferedFood = FoodType.Hay;
    }

    //Method
    public override void MakeSound()
    {
        AdjustHappiness(10);
        Debug.Log($"{Name} makes the sound. Happiness increased by 10.");
        Debug.Log($"{Name} mooing.");
    }

    public override void GetStatus()
    {
        base.GetStatus();
        Debug.Log($"Name: {Name}, Milk: {Milk}");
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

    public override string Produce()
    {
        switch (Happiness)
        {
            case <= 70:

                Debug.Log($"{Name} is not happy enough to produce milk. Happiness: {Happiness}");
                return $"Total milk: {Milk} Units";

            case > 70:

                int milkProduced = Happiness / 10;

                Milk += milkProduced;

                Debug.Log($"{Name} is going to produce milks");
                return $"Total milk: {Milk} Units";
        }
    }
}