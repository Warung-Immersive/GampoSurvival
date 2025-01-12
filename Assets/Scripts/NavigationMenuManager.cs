using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class NavigationMenuManager : MonoBehaviour
{
    [Serializable]
    struct Navigation
    {
        [SerializeField] public string name;
        [SerializeField] public Image image;
        [SerializeField] public GameObject page;
    }

    [SerializeField] private List<Navigation> navigations;
    void OnEnable()
    {
        OpenPage("Home");
    }

    public void OpenPage(string name)
    {
        foreach (var navigation in navigations)
        {
            if (navigation.name == name)
            {
                Color color = navigation.image.color; 
                color.a = 150 / 255.0f;
                navigation.image.color = color;

                navigation.page.SetActive(true);
            }
            else
            {
                Color color = navigation.image.color;
                color.a = 0 / 255.0f;
                navigation.image.color = color;

                navigation.page.SetActive(false);
            }
        }
    }

    public void QuitApplication()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif

        Application.Quit();
    }
}
