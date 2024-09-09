using UnityEngine;

public class click : MonoBehaviour
{
    public characterSelection characterSelectionManager;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("Mouse Position: " + mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null)
            {
                GameObject clickedObject = hit.collider.gameObject;
                Debug.Log("Object clicked: " + clickedObject.name);

                if (clickedObject.CompareTag("Character"))
                {
                    Debug.Log("Character clicked");
                    characterSelectionManager.SelectCharacter(clickedObject);
                }
                else if (clickedObject.CompareTag("Pet"))
                {
                    Debug.Log("Pet clicked");
                    characterSelectionManager.SelectPet(clickedObject);
                }
            }
            else
            {
                Debug.Log("Nothing hit by raycast");
            }
        }
    }
}

