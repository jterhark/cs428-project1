using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Button : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject btn;
    public GameObject spokesman;
    /// <summary>
    /// Called when the scene is loaded
    /// </summary>
    void Start()
    {
        btn = GameObject.Find("infoBtn");
        spokesman = GameObject.Find("spokesman");
        spokesman.SetActive(false);
        if (btn != null) {
            Debug.Log("found");
            btn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
            Debug.Log("Registered");

        }
        else {
            Debug.Log("not found");
        }
    }

    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        Debug.Log("Button Pressed");
        spokesman.SetActive(true);
        Invoke("Hide", 8);
    }

    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        Debug.Log("Button Released");
    }

    public void Hide() {
        spokesman.SetActive(false);
    }

}
