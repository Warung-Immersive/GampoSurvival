using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Seville
{
    public class PopupController : MonoBehaviour
    {
        private PopupData popupDataTemp;

        [Header("Component Dependencies")]
        [SerializeField] private PopupConfiguration popupConfig;

        [Space(4f)]
        [SerializeField] private GameObject panelMain;
        [SerializeField] private TextMeshProUGUI textTitle;
        [SerializeField] private GameObject imageSection;
        [SerializeField] private Image imageContent;
        [SerializeField] private GameObject textSection;
        [SerializeField] private TextMeshProUGUI textDescription;
        [SerializeField] private Button buttonOpenPopup;
        [SerializeField] private Button buttonClosePopup;


        private void Start()
        {
            buttonOpenPopup.onClick.AddListener(() => OpenOrClosePopupPanel(true));
            if (buttonClosePopup != null)
                buttonClosePopup.onClick.AddListener(() => OpenOrClosePopupPanel(false));

            if (popupConfig.isOpenOnStart) OpenOrClosePopupPanel(true);
        }

        public void OpenOrClosePopupPanel(bool isOpen)
        {
            if (isOpen)
            {
                if (popupDataTemp == null)
                {
                    if (string.IsNullOrEmpty(popupConfig.GetPopupData().descriptionText) &&
                        popupConfig.GetPopupData().contentSprite == null)
                    {
                        Debug.LogWarning("Seville Popup Controller: there is no content data in popup configuration");
                        return;
                    }
                    else popupDataTemp = popupConfig.GetPopupData();
                }

                UIAnimator.ScaleInObject(
                    panelMain,
                    () =>
                    {
                        buttonOpenPopup.gameObject.SetActive(false);

                        if (textTitle != null)
                            textTitle.text = !string.IsNullOrEmpty(popupDataTemp.titleText) ? popupDataTemp.titleText : "Popup Information";
                        if (textSection != null)
                            textSection.SetActive(!string.IsNullOrEmpty(popupDataTemp.descriptionText));
                        if (imageSection != null)
                            imageSection.SetActive(popupDataTemp.contentSprite != null);
                        if (textDescription != null)
                            textDescription.text = popupDataTemp.descriptionText;
                        if (imageContent != null)
                            imageContent.sprite = popupDataTemp.contentSprite;
                    },
                    () => { }
                );
            }
            else
            {
                UIAnimator.ScaleOutObject(
                    panelMain,
                    () => { },
                    () =>
                    {
                        buttonOpenPopup.gameObject.SetActive(true);
                    }
                );
            }
        }
    }
}