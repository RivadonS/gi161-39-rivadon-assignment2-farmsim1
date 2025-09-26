using UnityEngine;

public class Fox : Animal
{
    //Constructor
    public override void Init(string newName, int newHunger, int newHappiness)
    {
        base.Init(newName, newHunger, newHappiness);
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
}
