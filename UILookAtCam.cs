using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILookAtCam : MonoBehaviour
{

    public Camera mainCam;
    // Update is called once per frame
    private void Start()
    {
        mainCam = Camera.main;
    }
    void LateUpdate()
    {
        transform.LookAt(transform.position + mainCam.transform.forward);
    }
}
