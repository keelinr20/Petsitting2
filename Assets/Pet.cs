using UnityEngine;

public class Pet : MonoBehaviour
{
    public Sprite cat;
    public Sprite chicken;
    public Sprite cow;

    private SpriteRenderer sr;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        string petString = PlayerPrefs.GetString("SelectedPet");
        if (petString == "cat")
        {
            sr.sprite = cat;
        }
        else if (petString == "cow") sr.sprite = cow;
        else sr.sprite = chicken;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
