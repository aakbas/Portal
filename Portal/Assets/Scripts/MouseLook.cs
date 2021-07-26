using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensivity=100f;
    public Transform playerBody;
    float xRotation=0f;



    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState=CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
        float x = Input.GetAxis("Mouse X")*mouseSensivity*Time.deltaTime;
       
       // transform.localRotation=Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up*x);


    }
}
