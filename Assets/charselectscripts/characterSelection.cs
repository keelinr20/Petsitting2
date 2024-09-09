using UnityEngine;

public class characterSelection : MonoBehaviour
{
    public GameObject selectedCharacter;
    public GameObject selectedPet;

    public void SelectCharacter(GameObject character)
    {
        selectedCharacter = character;
        Debug.Log("Selected Character: " + character.name);
        PlayerPrefs.SetString("SelectedCharacter", selectedCharacter.name);
        PlayerPrefs.Save();
        
    }

    public void SelectPet(GameObject pet)
    {
        selectedPet = pet;
        PlayerPrefs.SetString("SelectedPet", selectedPet.name);
        PlayerPrefs.Save();
    }

}


