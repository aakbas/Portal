using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x=Input.GetAxis("Vertical");
        float z=Input.GetAxis("Horizontal");
        Vector3 move=transform.right*-x+transform.forward*-z;
        controller.Move(move*speed*Time.deltaTime);
    }
}