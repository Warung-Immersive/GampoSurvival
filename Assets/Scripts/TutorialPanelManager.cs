using UnityEngine;
using Seville;
using Tproject.AudioManager;

public class TutorialPanelManager : MonoBehaviour
{
    [SerializeField] private GameObject locomotionSystem;
    [SerializeField] private AudioManager audioManager;

    void OnEnable()
    {
        locomotionSystem.SetActive(false);
    }

    void OnDisable()
    {
        locomotionSystem.SetActive(true);
        audioManager.PlayBackgroundMusic("Earthquake");
    }
}
