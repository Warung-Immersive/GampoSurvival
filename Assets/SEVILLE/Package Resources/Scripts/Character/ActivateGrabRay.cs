using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Seville
{
    public class ActivateGrabRay : MonoBehaviour
    {
        public GameObject rightGrabRay;
        public GameObject leftGrabRay;

        public UnityEngine.XR.Interaction.Toolkit.Interactors.XRDirectInteractor rightDirectGrab;
        public UnityEngine.XR.Interaction.Toolkit.Interactors.XRDirectInteractor leftDirectGrab;

        private void Update()
        {
            leftGrabRay.SetActive(leftDirectGrab.interactablesSelected.Count == 0);
            rightGrabRay.SetActive(rightDirectGrab.interactablesSelected.Count == 0);
        }
    }
}