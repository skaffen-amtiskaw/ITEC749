using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class vbtnController : MonoBehaviour
{
    GameObject virtualButtonObj;
    public GameObject textPanel;

    void Start()
    {
        virtualButtonObj = GameObject.Find("biPolarBtn");
        virtualButtonObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(VirtualBtnPressed);
        virtualButtonObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(VirtualBtnReleased);

        textPanel.SetActive(false);
    }

    public void VirtualBtnPressed(VirtualButtonBehaviour vb)
    {
        textPanel.SetActive(true);
    }
    public void VirtualBtnReleased(VirtualButtonBehaviour vb)
    {
        textPanel.SetActive(false);
    }
}
