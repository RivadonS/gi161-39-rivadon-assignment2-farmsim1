using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Chicken chicken = new Chicken("Chicken Specimen 1", 20, 20, 0);
        Cow cow = new Cow("Cow Specimen 1", 25, 25, 0);

        //Chicken
        chicken.GetStatus();
        Debug.Log("----------Feeding a Chicken----------");
        chicken.Feed("Grains");
        chicken.GetStatus();
        chicken.Sleep();
        chicken.GetStatus();

        //Cow
        cow.GetStatus();
        Debug.Log("----------Feeding a Cow----------");
        cow.Feed("Wheat");
        cow.GetStatus();
        cow.Moo();
        cow.GetStatus();
    }
}
