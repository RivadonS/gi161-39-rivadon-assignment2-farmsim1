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
    public void Init(string newName, int newHunger, int newHappiness, float newMilk)
    {
        base.Init(newName, newHunger, newHappiness); 
        Milk = newMilk;
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

    public void Feeds(string foodTypes, int amountFood)
    {
        string FoodTypes = foodTypes;
        Debug.Log($"{Name} is eating {FoodTypes}");
        base.Feed(amountFood);
    }
}