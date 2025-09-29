using UnityEngine;
public class Chicken : Animal
{
    private int eggs;
    public int Eggs
    {
        get => eggs;
        private set => eggs = (value < 0) ? 0 : value;
    }
    //Constructor
    public void InitChicken(string newName)
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
                break;
            case FoodType.AnimalFood:
                base.Feed(amountFood);
                break;
            default:
                Debug.Log($"{Name} is happy because eating {preferedFood} in amount of {amountFood}." +
                    $"Latest Happiness: {Happiness}");
                AdjustHunger(-amountFood);
                AdjustHappiness(15);
                break;
        }
    }
    public override string Produce()
    {
        switch (Happiness)
        {
            case <= 50:
                Debug.Log($"{Name} is not happy enough to produce eggs. Happiness: {Happiness}");
                return $"Total eggs: {Eggs}";
            case >= 51 and <= 79:
                int eggsProduced = 2;
                Eggs += eggsProduced;
                Debug.Log($"{Name} is going to produce eggs. Amount produced this round: {eggsProduced} eggs.");
                Debug.Log($"Total eggs: {Eggs} eggs");
                return $"Total eggs: {Eggs} eggs";
            case >= 80:
                int eggsProducedHigh = 3;
                Eggs += eggsProducedHigh;
                Debug.Log($"{Name} is going to produce eggs. Amount produced this round: {eggsProducedHigh} eggs.");
                Debug.Log($"Total eggs: {Eggs} eggs");
                return $"Total eggs: {Eggs} eggs";
        }
    }
}