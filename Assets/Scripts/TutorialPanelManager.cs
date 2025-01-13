using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TutorialPanelManager : MonoBehaviour
{
    [SerializeField] private GameObject locomotionSystem;

    void OnEnable()
    {
        locomotionSystem.SetActive(false);
    }

    void OnDisable()
    {
        locomotionSystem.SetActive(true);
    }
}
