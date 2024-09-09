using UnityEngine;

public class click : MonoBehaviour
{
    private characterSelection characterSelectionManager;

    void Start()
    {
        characterSelectionManager = GetComponent<characterSelection>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null)
            {
                GameObject clickedObject = hit.collider.gameObject;

                if (clickedObject.CompareTag("Character"))
                {
                    Debug.Log("Selected Character: " + clickedObject.name);
                    characterSelectionManager.SelectCharacter(clickedObject);
                }
                else if (clickedObject.CompareTag("Pet"))
                {
                    Debug.Log("Selected Pet: " + clickedObject.name);
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
