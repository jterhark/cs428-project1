using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class reviews_nav : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject prevBtn, nextBtn;
    public List<GameObject> reviews;
    private int active = 0;

    // Start is called before the first frame update
    void Start()
    {
        prevBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        nextBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Redraw();
    }

    private void Redraw() {
        reviews.ForEach(x => x.SetActive(false));
        reviews[active].SetActive(true);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log($"{vb.VirtualButtonName} pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log($"{vb.VirtualButtonName} released");
        switch (vb.VirtualButtonName) {
            case "prev":
                active = (active - 1) % reviews.Count;
                Debug.Log("prev shown");
                break;
            case "next":
                active = (active + 1) % reviews.Count;
                Debug.Log("next shown");
                break;
            default:
                break;
        }

        Redraw();
    }
}
