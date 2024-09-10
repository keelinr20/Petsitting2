using UnityEngine;

public class GameController1 : MonoBehaviour
{
    public int hunger;
    public int bathroom;
    public int hygiene;
    public int thirst;
    public int entertainment;
    public int sleep;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hunger = 10;
        bathroom = 10;
        hygiene = 10;
        thirst = 10;
        entertainment = 10;
        sleep = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void replaceSleep()
    {
        sleep = 10;
    }

    public void replaceBathroom()
    {
        bathroom = 10;
    }
    public void replaceHunger()
    {
        hunger = 10;
    }
    public void replaceHygiene()
    {
        hygiene = 10;
    }
    public void replaceEntertainment()
    {
        entertainment = 10;
    }
    public void replaceThirst()
    {
        thirst = 10;
    }

}
