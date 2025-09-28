using UnityEngine;
public enum FoodType { Hay, Grain, Apple, RottenFood, AnimalFood }

public abstract class Animal : MonoBehaviour
{
    public string Name { get; set; } = "Unknown Name";
    public int Hunger { get; private set; } = 50;
    public int Happiness { get; private set; } = 50;
    public FoodType PreferedFood { get; protected set; }

    public virtual void InitAnimal(string newName)
    {
        Name = string.IsNullOrEmpty(newName) ? "Unknown Name" : newName;
        Hunger = Happiness = 50;
        SetPreferedFood();
    }

    protected abstract void SetPreferedFood();

    public int AdjustHunger(int amount) => Hunger = Mathf.Clamp(Hunger + amount, 0, 100);
    public int AdjustHappiness(int amount) => Happiness = Mathf.Clamp(Happiness + amount, 0, 100);

    public virtual void Feed(int amountFood)
    {
        AdjustHunger(-amountFood);
        AdjustHappiness(amountFood / 2);
        Debug.Log($"{Name} ate food at the amount of {amountFood}.");
    }

    public virtual void GetStatus() => Debug.Log($"{Name} --> Hunger = {Hunger}, Happiness = {Happiness}, PreferedFood = {PreferedFood}");

    public void Feeds(FoodType foodType, int amountFood)
    {
        switch (foodType)
        {
            case FoodType.RottenFood:
                AdjustHappiness(-20);
                Debug.Log($"{Name} ate RottenFood. Hunger unchanged, Happiness decreased by 20.");
                break;
            case FoodType.AnimalFood:
                Feed(amountFood);
                break;
            default:
                AdjustHunger(-amountFood);
                AdjustHappiness(15);
                Debug.Log($"{Name} is happy eating {foodType} in amount of {amountFood}.");
                break;
        }
    }

    public abstract void MakeSound();
    public abstract string Produce();
}