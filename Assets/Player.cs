using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite sprite;

    private SpriteRenderer sr;
    private Rigidbody2D rb;

	void Start()
	{
		sr = GetComponent<SpriteRenderer>();
		rb = GetComponent<Rigidbody2D>();

	}

	void Update()
	{

	}
}
