using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public float speedH = 10.0f;
    public float speedV = 0.3f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        if(pitch < -90.0 ) { pitch = -90.0f; }
        else if(pitch > 90.0) { pitch = 90.0f; }
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

    }
}