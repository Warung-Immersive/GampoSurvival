using UnityEngine;
using TMPro;
using ApplicationStorage;

public class InputUsernameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI userInput;
    // Start is called before the first frame update
    void Start()
    {
        string username = PlayerPrefsManager.GetString("username");
        if (!string.IsNullOrEmpty(username) )
            gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void SaveUsername()
    {
        PlayerPrefsManager.SaveString("username", userInput.text);
        gameObject.SetActive(false);
    }
}
