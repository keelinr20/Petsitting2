using UnityEngine;

public class characterSelection : MonoBehaviour
{
    public GameObject selectedCharacter;
    public GameObject selectedPet;

    public void SelectCharacter(GameObject character)
    {
        selectedCharacter = character;
        Debug.Log("Selected Character: " + character.name);
    }

    public void SelectPet(GameObject pet)
    {
        selectedPet = pet;
        Debug.Log("Selected Pet: " + pet.name);
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
        else
        {
            Debug.LogError("Character or Pet not selected!");
        }
    }
}


