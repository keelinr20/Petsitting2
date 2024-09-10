using UnityEngine;

public class GameController1 : MonoBehaviour
{
    public float hunger;
    public float bathroom;
    public float hygiene;
    public float thirst;
    public float entertainment;
    public float sleep;

    public float hungerDecSpeed;
    public float bathroomDecSpeed;
    public float hygieneDecSpeed;
    public float thirstDecSpeed;
    public float entertainmentDecSpeed;
    public float sleepDecSpeed;

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
        checkDeath();
        hunger -= hungerDecSpeed * Time.deltaTime;
        bathroom -= bathroomDecSpeed * Time.deltaTime;
        hygiene -= hygieneDecSpeed * Time.deltaTime;
        thirst -= thirstDecSpeed * Time.deltaTime;
        entertainment -= entertainmentDecSpeed * Time.deltaTime;
        sleep -= sleepDecSpeed * Time.deltaTime;
        Debug.Log("Hunger = " + hunger + ", Bathroom = " + bathroom);
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

    void checkDeath()
    {
        if (hunger <= 0 || bathroom <= 0 || hygiene <= 0 || thirst <= 0 || entertainment <= 0 || sleep <= 0)
        {
            return;
        }
    }

}
