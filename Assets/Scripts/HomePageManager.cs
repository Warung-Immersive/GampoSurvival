using UnityEngine;
using ApplicationStorage;
using TMPro;
using System.Collections.Generic;

namespace MainMenu
{
    public class HomePageManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI username;
        [SerializeField] private List<TextMeshProUGUI> progress = new List<TextMeshProUGUI>();
        [SerializeField] private List<GameObject> tropies = new List<GameObject>();

        // Start is called before the first frame update
        private void OnEnable()
        {
            username.text = $"Hi {PlayerPrefsManager.GetString("username")}";

            int[] complete = GetProgress();
            ShowProgress(complete);
            
            ShowAchievement();
        }

        private int[] GetProgress()
        {
            int videos = CountProgress("video");
            int practices = CountProgress("practice");
            int achievement = CountProgress("achievement");
            return new int[] { videos, practices, achievement }; 
        }

        private int CountProgress(string key)
        {
            int count = 0;
            for (int i = 0; i < 4; i++)
                count += PlayerPrefsManager.GetInt(key + (i + 1));

            return count;
        }

        private void ShowProgress(int[] values)
        {
            progress[0].text = values[0].ToString() + " of 3";
            progress[1].text = values[1].ToString() + " of 3";
            progress[2].text = values[2].ToString() + " of 4";
        }

        private void ShowAchievement()
        {
            for (int i = 0; i < 4; i++)
            {
                if (PlayerPrefsManager.GetInt("achievement" + (i + 1)) != 0)
                    tropies[i].SetActive(true);
                else
                    tropies[i].SetActive(false);
            }
        }
    }
}