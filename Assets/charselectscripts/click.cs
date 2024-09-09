using UnityEngine;

public class click : MonoBehaviour
{
    public characterSelection characterSelectionManager;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null)
            {
                GameObject clickedObject = hit.collider.gameObject;
                Debug.Log("Object clicked: " + clickedObject.name);

                if (clickedObject.CompareTag("Character"))
                {
                    Debug.Log("Character clicked");
                    if (characterSelectionManager != null)
                    {
                        characterSelectionManager.SelectCharacter(clickedObject);
                    }
                    else
                    {
                        Debug.LogError("CharacterSelectionManager is not assigned!");
                    }
                }

                else if (clickedObject.CompareTag("Pet"))
                {
                    Debug.Log("Pet clicked");
                    if (characterSelectionManager != null)
                    {
                        characterSelectionManager.SelectPet(clickedObject);
                    }
                    else
                    {
                        Debug.LogError("CharacterSelectionManager is not assigned!");
                    }
                }
            }
            else
            {
                Debug.Log("Nothing hit by raycast");
            }
        }
    }
}

