using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Animal> animals = new List<Animal>();
    public List<Animal> animalsCount = new List<Animal>();
    void Start()
    {
        Chicken chicken1 = (Chicken)Instantiate(animals[0]);
        chicken1.Init("Luffytaro");
        animalsCount.Add(chicken1);

        Cow cow1 = (Cow)Instantiate(animals[1]);
        cow1.Init("Zorojuro");
        animalsCount.Add(cow1);

        Fox fox1 = (Fox)Instantiate(animals[2]);
        fox1.Init("Usoppun");
        animalsCount.Add(fox1);

        Debug.Log("Welcome to Farm Sim");
        Debug.Log($"There are {animalsCount.Count} animals in the farm.");

        foreach (Animal animal in animalsCount)
        {
            animal.GetStatus();
            animal.MakeSound();
            animal.Feed(5);
        }
    }
}