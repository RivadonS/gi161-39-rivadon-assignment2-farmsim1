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
        cow = CreateAnimal<Cow>(0, "Zorojuro");
        chicken = CreateAnimal<Chicken>(1, "Luffytaro");
        fox = CreateAnimal<Fox>(2, "Usoppun");

        Debug.Log("*** Welcome to Farm Sim ***");
        Debug.Log($"There are {animalsCount.Count} animals in the farm. --> ");
        animalsCount.ForEach(animal => animal.GetStatus());

        Debug.Log("\n*** Feeding Time ***");
        cow.Feed(10); cow.Feed(5); cow.Feeds(FoodType.Hay, 20); cow.Produce();
        chicken.Feeds(FoodType.RottenFood, 20); chicken.Produce();
        chicken.Feeds(FoodType.RottenFood, 10); chicken.Produce();
        chicken.Feeds(FoodType.RottenFood, 5); chicken.Produce();
        fox.Feeds(FoodType.Apple, 50); fox.Produce();
    }

    private T CreateAnimal<T>(int index, string name) where T : Animal
    {
        var animal = (T)Instantiate(animals[index]);
        animal.InitAnimal(name);
        animalsCount.Add(animal);
        return animal;
    }
}