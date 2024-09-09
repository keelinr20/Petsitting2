using UnityEngine;

public class charsetup : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public GameObject[] petPrefabs;

    void Start()
    {
        string selectedCharacterName = PlayerPrefs.GetString("SelectedCharacter");
        string selectedPetName = PlayerPrefs.GetString("SelectedPet");

        InstantiateSelectedCharacter(selectedCharacterName);
        InstantiateSelectedPet(selectedPetName);
    }

    void InstantiateSelectedCharacter(string characterName)
    {
        foreach (GameObject characterPrefab in characterPrefabs)
        {
            if (characterPrefab.name == characterName)
            {
                Instantiate(characterPrefab, new Vector3(-2, 0, 0), Quaternion.identity);
                Debug.Log("Instantiated Character: " + characterName);
                break;
            }
        }
    }

    void InstantiateSelectedPet(string petName)
    {
        foreach (GameObject petPrefab in petPrefabs)
        {
            if (petPrefab.name == petName)
            {
                Instantiate(petPrefab, new Vector3(2, 0, 0), Quaternion.identity);
                Debug.Log("Instantiated Pet: " + petName);
                break;
            }
        }
    }
}
