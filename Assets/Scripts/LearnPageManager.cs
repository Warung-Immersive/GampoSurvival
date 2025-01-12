using ApplicationStorage;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LearnPageManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI subtitle;
    [SerializeField] private List<GameObject> completeLabel = new List<GameObject>();

    // Start is called before the first frame update
    void OnEnable()
    {
        subtitle.text = "Learning materials";
        
        ShowLabel();
    }

    private void ShowLabel()
    {
        for (int i = 0; i < 3; i++)
        {
            if (PlayerPrefsManager.GetInt("achievement" + (i + 1)) != 0)
                completeLabel[i].SetActive(true);
            else
                completeLabel[i].SetActive(false);
        }
    }
}
