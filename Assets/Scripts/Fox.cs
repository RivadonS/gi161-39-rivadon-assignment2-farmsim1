using UnityEngine;

public class Fox : Animal
{

    private int truffles;
    public int Truffles
    {
        get => truffles;
        private set => truffles = (value < 0) ? 0 : value;
    }

    //Constructor
    public void InitFox(string newName)
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

    public override string Produce()
    {
        switch (Happiness)
        {
            case <= 70:

                Debug.Log($"{Name} is not happy enough to produce eggs. Happiness: {Happiness}");
                return $"Total eggs: {Truffles}";

            case >= 71:

                int truffleProduced = Happiness / 10;

                Truffles += truffleProduced;

                Debug.Log($"{Name} is going to produce truffles. Amount produced this round: {truffleProduced} eggs.");
                return $"Total eggs: {Truffles}";
        }
    }
}
