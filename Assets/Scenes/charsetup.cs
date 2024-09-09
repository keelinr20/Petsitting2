using UnityEngine;

public class charsetup : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public GameObject[] petPrefabs;
    private GameObject instantiatedCharacter;
    private GameObject instantiatedPet;

    void Start()
    {
        string selectedCharacterName = PlayerPrefs.GetString("SelectedCharacter", "");
        string selectedPetName = PlayerPrefs.GetString("SelectedPet", "");


        if (string.IsNullOrEmpty(selectedCharacterName) || string.IsNullOrEmpty(selectedPetName))
        {
            Debug.LogError("Selected character or pet not found in PlayerPrefs");
            return;
        }

        InstantiateSelectedCharacter(selectedCharacterName);
        InstantiateSelectedPet(selectedPetName);
    }

    void InstantiateSelectedCharacter(string characterName)
    {
        foreach (GameObject characterPrefab in characterPrefabs)
        {
            if (characterPrefab.name == characterName)
            {
                instantiatedCharacter = Instantiate(characterPrefab, new Vector3(3, 0, 0), Quaternion.identity);
                Debug.Log("Instantiated Character: " + characterName);
                return;
            }
        }
        Debug.LogError("Character prefab not found: " + characterName);
    }

    void InstantiateSelectedPet(string petName)
    {
        foreach (GameObject petPrefab in petPrefabs)
        {
            if (petPrefab.name == petName)
            {
                instantiatedPet = Instantiate(petPrefab, instantiatedCharacter.transform.position + new Vector3(6, 0, 0), Quaternion.identity);
                Debug.Log("Instantiated Pet: " + petName);
                return;
            }
        }
        Debug.LogError("Pet prefab not found: " + petName);
    }
}


