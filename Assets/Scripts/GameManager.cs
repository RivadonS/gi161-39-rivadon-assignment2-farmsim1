using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Animal> farmAnimals = new List<Animal>();
    public Chicken currentChicken;
    public Cow currentCow;

    void Start()
    {
        DisplayGameName("My FarmVille");

        if (currentChicken != null)
        {
            currentChicken.Init("Chicky", 10, 10, 0);
        }

        if (currentCow != null)
        {
            currentCow.Init("Milly", 20, 20, 0);
        }

        if (currentChicken != null)
        {
            farmAnimals.Add(currentChicken);
        }

        if (currentCow != null)
        {
            farmAnimals.Add(currentCow);
        }

        DisplayAnimalCount();

        foreach (Animal animal in farmAnimals)
        {
            animal.GetStatus();
        }

        foreach (Animal animal in farmAnimals)
        {
            animal.MakeSound();
        }

        foreach (Animal animal in farmAnimals)
        {
            animal.Feed(5);
        }
    }

    public void DisplayGameName(string gameName)
    {
        Debug.Log($"Welcome to {gameName}!");
    }

    public void DisplayAnimalCount()
    {
        Debug.Log($"There are {farmAnimals.Count} animals on the farm.");
    }
}