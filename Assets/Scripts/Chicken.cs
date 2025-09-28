using UnityEngine;
public class Chicken : Animal
{
    public int Eggs { get; private set; }

    protected override void SetPreferedFood() => PreferedFood = FoodType.Grain;

    public override void MakeSound()
    {
        AdjustHappiness(10);
        Debug.Log($"{Name} makes the sound. Happiness increased by 10.\n{Name} clucking.");
    }

    public override void GetStatus()
    {
        base.GetStatus();
        Debug.Log($"Name: {Name}, Eggs: {Eggs}");
    }

    public override string Produce()
    {
        int eggsProduced = Happiness switch
        {
            <= 50 => 0,
            >= 51 and <= 79 => 2,
            >= 80 => 3
        };

        if (eggsProduced == 0)
        {
            Debug.Log($"{Name} is not happy enough to produce eggs. Happiness: {Happiness}");
            return $"Total eggs: {Eggs}";
        }

        Eggs += eggsProduced;
        Debug.Log($"{Name} is going to produce eggs. Amount produced this round: {eggsProduced} eggs.\nTotal eggs: {Eggs} eggs");
        return $"Total eggs: {Eggs} eggs";
    }
}