using UnityEngine;
using UnityEngine.UI;

public class Bed2 : MonoBehaviour
{
    public float interactionRange;
    public Text interactionPrompt;
    public GameObject player;
    public GameController1 gc;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (interactionPrompt != null)
        {
            interactionPrompt.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        checkClick();
    }

    void checkClick()
    {
        float distanceToPlayer = Vector3.Distance(player.transform.position, transform.position);
        if (distanceToPlayer <= interactionRange)
        {
            AllowInteraction();
        }
        //else interactionPrompt.enabled = false;

    }

     void AllowInteraction()
    {
        //interactionPrompt.enabled = true;
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == this.gameObject)
            {
                Interact();
            }
        }
    }

      void Interact()
    {
        Debug.Log("Sleep need fulfilled");
        gc.replaceSleep();
    }
}
