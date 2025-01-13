using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHeartManager : MonoBehaviour
{
    [SerializeField] private List<Image> hearts;
    private int totalHeart;
    private int currentHeart;

    private bool isInSafeZone;

    [SerializeField] private int level;
    // Start is called before the first frame update
    void OnEnable()
    {
        totalHeart = hearts.Count;
        currentHeart = totalHeart - 1;

        foreach (var heart in hearts)
        {
            Color newColor;
            if (ColorUtility.TryParseHtmlString("#FE251B", out newColor))
            {
                heart.color = newColor;
            }
            else
            {
                Debug.LogError("Invalid color code");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayerPanic()
    {
        Color newColor;
        if (ColorUtility.TryParseHtmlString("#787878", out newColor))
        {
            hearts[currentHeart].color = newColor;
            currentHeart--;
        }
        else
        {
            Debug.LogError("Invalid color code");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SafeZone"))
        {
            isInSafeZone = true;
            Debug.Log("Player entered safe zone");
        }
        else if (other.CompareTag("DangerZone"))
        {
            isInSafeZone = false;
            Debug.Log("Player entered danger zone");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SafeZone") || other.CompareTag("DangerZone"))
        {
            isInSafeZone = false;
            Debug.Log("Player exited zone");
        }
    }

    private void PlayLevelOne()
    {

    }
}
