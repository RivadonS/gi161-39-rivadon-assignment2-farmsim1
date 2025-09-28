using UnityEngine;
public class Cow : Animal
{
    public float Milk { get; private set; }

    protected override void SetPreferedFood() => PreferedFood = FoodType.Hay;

    public override void MakeSound()
    {
        AdjustHappiness(10);
        Debug.Log($"{Name} makes the sound. Happiness increased by 10.\n{Name} mooing.");
    }

    public override void GetStatus()
    {
        base.GetStatus();
        Debug.Log($"Name: {Name}, Milk: {Milk}");
    }

    public override string Produce()
    {
        if (Happiness <= 70)
        {
            Debug.Log($"{Name} is not happy enough to produce milk. Happiness: {Happiness}");
            return $"Total milk: {Milk} units";
        }

        int milkProduced = Happiness / 10;
        Milk += milkProduced;
        Debug.Log($"{Name} is going to produce milk. Amount produced this round: {milkProduced} units.\nTotal Milk: {Milk} units.");
        return $"Total milk: {Milk} units";
    }
}