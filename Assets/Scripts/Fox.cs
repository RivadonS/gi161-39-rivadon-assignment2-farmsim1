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
        base.MakeSound();
        Debug.Log($"{Name} barking.");
    }

    public override void GetStatus()
    {
        base.GetStatus();
    }
}
