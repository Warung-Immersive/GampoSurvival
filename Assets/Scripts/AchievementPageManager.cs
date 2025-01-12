using ApplicationStorage;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AchievementPageManager : MonoBehaviour
{
    [Serializable] struct Achievement
    {
        [SerializeField] public GameObject unlocked;
        [SerializeField] public GameObject locked;
        [SerializeField] public GameObject name;
    }

    [SerializeField] private TextMeshProUGUI subtitle;
    [SerializeField] private List<Achievement> achievement;

    void OnEnable()
    {
        subtitle.text = "Achievement";
        
        for (int i = 0; i < 4; i++)
        {
            if (PlayerPrefsManager.GetInt("achievement" + (i + 1)) != 0)
            {
                achievement[i].unlocked.SetActive(true);
                achievement[i].locked.SetActive(false);
                achievement[i].name.SetActive(true);
            }
            else
            {
                achievement[i].unlocked.SetActive(false);
                achievement[i].locked.SetActive(true);
                achievement[i].name.SetActive(false);
            }
        }
    }
}
