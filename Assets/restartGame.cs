using UnityEngine;
using UnityEngine.SceneManagement;

public class restartButton : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detect left mouse button click
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Get mouse position
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            // Check if the click hit this sprite's collider
            if (hit.collider != null && hit.collider.gameObject == this.gameObject)
            {
                Debug.Log("Sprite Button Clicked, Loading Main Menu...");
                SceneManager.LoadScene("Main Menu"); // Change scene to main menu
            }
        }
    }
}