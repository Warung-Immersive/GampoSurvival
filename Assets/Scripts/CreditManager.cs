using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreditManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI subtitle;
    [SerializeField] private TextMeshProUGUI credit;

    private string[] categories = new string[3];
    private string[] names = new string[3];
    private string credits;

    void OnEnable()
    {
        subtitle.text = "Credits";

        SetAllCategories();
        SetAllNames();
        credits = WriteCredit();

        credit.text = credits;
    }

    private void SetAllCategories()
    {
        categories[0] = "Development Team\r\n".ToUpper();
        categories[1] = "Plugins and Tools\r\n".ToUpper();
        categories[2] = "Asset Creators\r\n".ToUpper();
    }

    private void SetAllNames()
    {
        names[0] = "Kholil Asjaduddin\r\nMoses Saidasdo Purba\r\n\r\n";
        names[1] = "Seville by smarteye.id\r\niconify\r\nSkybox AI by Blockade Labs\r\nPictory AI\r\n\r\n";
        names[2] = "Asset Creators";
    }

    private string WriteCredit()
    {
        return $"{categories[0]}{names[0]}{categories[1]}{names[1]}{categories[2]}{names[2]}";
    }
}
