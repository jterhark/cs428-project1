using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class back_nav_btns : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject videoBtn, infoBtn, reviewsBtn;
    public GameObject videoPanel, infoPanel, reviewPanels;

    // Start is called before the first frame update
    void Start()
    {
        videoBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        infoBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        reviewsBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        videoPanel.SetActive(false);
        infoPanel.SetActive(true);
        reviewPanels.SetActive(false);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log($"{vb.VirtualButtonName} pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log($"{vb.VirtualButtonName} released");
        switch (vb.VirtualButtonName) {
            case "info":
                videoPanel.SetActive(false);
                infoPanel.SetActive(true);
                reviewPanels.SetActive(false);
                Debug.Log("info shown");
                break;
            case "reviews":
                videoPanel.SetActive(false);
                infoPanel.SetActive(false);
                reviewPanels.SetActive(true);
                Debug.Log("reviews shown");
                break;
            case "video":
                videoPanel.SetActive(true);
                infoPanel.SetActive(false);
                reviewPanels.SetActive(false);
                Debug.Log("video shown");
                break;
            default:
                Debug.Log("Nothing Shown!");
                break;
        }
    }

}
