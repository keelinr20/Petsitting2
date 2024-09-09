using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite blueberry;
	public Sprite orange;

    private SpriteRenderer sr;
    private Rigidbody2D rb;

	void Start()
	{
		sr = GetComponent<SpriteRenderer>();
		rb = GetComponent<Rigidbody2D>();
		string spriteString = PlayerPrefs.GetString("SelectedCharacter");
		if (spriteString == "orange")
		{
			sr.sprite = orange;
		}
		else sr.sprite = blueberry;
	}

	void Update()
	{

	}
}
