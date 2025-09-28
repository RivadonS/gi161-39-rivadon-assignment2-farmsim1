using UnityEngine;
public class Fox : Animal
{
    public int Truffles { get; private set; }

    protected override void SetPreferedFood() => PreferedFood = FoodType.Apple;

    public override void MakeSound()
    {
        AdjustHappiness(10);
        Debug.Log($"{Name} makes the sound. Happiness increased by 10.\n{Name} barking.");
    }

    public override void GetStatus()
    {
        base.GetStatus();
        Debug.Log($"Name: {Name}, Truffle: {Truffles}");
    }

    public override string Produce()
    {
        if (Happiness <= 70)
        {
            Debug.Log($"{Name} is not happy enough to produce truffles. Happiness: {Happiness}");
            return $"Total truffles: {Truffles}";
        }

        int truffleProduced = Happiness / 10;
        Truffles += truffleProduced;
        Debug.Log($"{Name} is going to produce truffles. Amount produced this round: {truffleProduced} units.\nTotal truffles: {Truffles} units.");
        return $"Total truffles: {Truffles}";
    }
}