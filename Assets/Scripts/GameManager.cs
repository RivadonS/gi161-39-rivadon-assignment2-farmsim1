using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public List<Animal> animals = new List<Animal>();
    public List<Animal> animalsCount = new List<Animal>();
    private Cow cow;
    private Chicken chicken;
    private Fox fox;
    void Start()
    {
        CreateCow("Zorojuro");
        CreateChicken("Luffytaro");
        CreateFox("Usoppun");
        Debug.Log(" Welcome to Farm Sim ");
        Debug.Log($"There are {animalsCount.Count} animals in the farm. --> ");
        foreach (Animal animal in animalsCount)
        {
            animal.GetStatus();
        }
        Debug.Log("\n Feeding Time ");
        cow.Feed(10);
        cow.Feed(5);
        cow.Feeds(FoodType.Hay, 20);
        cow.Produce();
        chicken.Feeds(FoodType.RottenFood, 20);
        chicken.Produce();
        chicken.Feeds(FoodType.RottenFood, 10);
        chicken.Produce();
        fox.Feeds(FoodType.Apple, 50);
        fox.Produce();
    }
    private void CreateCow(string name)
    {
        cow = (Cow)Instantiate(animals[0]);
        cow.InitCow(name);
        animalsCount.Add(cow);
    }
    private void CreateChicken(string name)
    {
        chicken = (Chicken)Instantiate(animals[1]);
        chicken.InitChicken(name);
        animalsCount.Add(chicken);
    }
    private void CreateFox(string name)
    {
        fox = (Fox)(Instantiate(animals[2]));
        fox.InitFox(name);
        animalsCount.Add(fox);
    }
}