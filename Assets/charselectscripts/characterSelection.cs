using UnityEngine;
using UnityEngine.UI;

public class characterSelection : MonoBehaviour
{
    public GameObject selectedCharacter;
    public GameObject selectedPet;

    public void SelectCharacter(GameObject character)
    {
        selectedCharacter = character;
    }

    public void SelectPet(GameObject pet)
    {
        selectedPet = pet;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ConfirmSelection();
        }
    }

    public void ConfirmSelection()
    {
        if (selectedCharacter != null && selectedPet != null)
        {
            PlayerPrefs.SetString("SelectedCharacter", selectedCharacter.name);
            PlayerPrefs.SetString("SelectedPet", selectedPet.name);
            PlayerPrefs.Save();

            UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
        }
    }
}
