using UnityEngine;
using UnityEngine.UI;

public class Bed2 : MonoBehaviour
{
    private float sleep;
    public float interactionRange;
    public Text interactionPrompt;
    public GameObject player;

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
            Debug.Log("clicked");

            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
            Debug.Log(hit.collider.gameObject);
            if (hit.collider != null && hit.collider.gameObject == this.gameObject)
            {
                Debug.Log("Hit collider");
                Interact();
            }
        }
    }

      void Interact()
    {
        Debug.Log("Sleep need fulfilled");
        sleep++;
    }
}
