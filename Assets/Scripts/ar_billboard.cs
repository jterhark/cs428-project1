using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ar_billboard : MonoBehaviour
{
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.rotation = Quaternion.LookRotation(camera.transform.position);
    }


}
