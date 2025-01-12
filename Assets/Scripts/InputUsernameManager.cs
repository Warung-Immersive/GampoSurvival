using UnityEngine;
using TMPro;
using ApplicationStorage;
using System.Collections.Generic;
using Seville;

public class InputUsernameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI userInput;
    [SerializeField] private List<PopupController> menus;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefsManager.DeleteAll();
        string username = PlayerPrefsManager.GetString("username");
        if (!string.IsNullOrEmpty(username))
        {
            foreach (var menu in menus)
            {
                menu.OpenOrClosePopupPanel(true);
            }
            gameObject.SetActive(false); 
        }
    }

    // Update is called once per frame
    public void SaveUsername()
    {
        PlayerPrefsManager.SaveString("username", userInput.text);
        gameObject.SetActive(false);
    }
}
