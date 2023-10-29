using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectController : MonoBehaviour
{
    public float PCRotationSpeed = 10f;
    public float MobileRotationSpeed = 0.4f;
    //Drag the camera object here
    public Camera cam;

    public float returnSpeed = 2.0f; // Adjust this for the return speed.

    private bool isRotating = false;
    private Quaternion originalRotation;
    private Quaternion targetRotation;

    private void Start()
    {
        originalRotation = transform.rotation;
    }
    //void OnMouseDrag()
    //{
    //    float rotX = Input.GetAxis("Mouse X") * PCRotationSpeed;
    //    float rotY = Input.GetAxis("Mouse Y") * PCRotationSpeed;

    //    Vector3 right = Vector3.Cross(cam.transform.up, transform.position - cam.transform.position);
    //    Vector3 up = Vector3.Cross(transform.position - cam.transform.position, right);
    //    transform.rotation = Quaternion.AngleAxis(-rotX, up) * transform.rotation;
    //    transform.rotation = Quaternion.AngleAxis(rotY, right) * transform.rotation;
    //}

    void Update()
    {
  
        foreach (Touch touch in Input.touches)
        {
           if (touch.phase != TouchPhase.Ended)
           { 
            Ray camRay = cam.ScreenPointToRay(touch.position);
            RaycastHit raycastHit;
                if (Physics.Raycast(camRay, out raycastHit, 10))
                {
                    if (touch.phase == TouchPhase.Moved)
                    {
                        isRotating = true;
                        transform.Rotate(touch.deltaPosition.y * MobileRotationSpeed,
                         -touch.deltaPosition.x * MobileRotationSpeed, 0, Space.World);
                    }
                }
           }
            else
            {
                isRotating = false;
            }
        }

        if (!isRotating)
        {
            // Smoothly interpolate back to the original rotation.
            transform.rotation = Quaternion.Lerp(transform.rotation, originalRotation, Time.deltaTime * returnSpeed);
        }
       
    }



}
