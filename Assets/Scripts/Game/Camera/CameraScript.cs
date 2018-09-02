using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    
   // private Transform target;

    public Vector3 offset;
    public float smoothSpeed = 0.125f;
    public float cameraSpeedH = 10.0f;
    public float cameraSpeedV = 0.3f;

    private Vector3 desiredPosition;
    private Vector3 smoothedPostion;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Use this for initialization
    void Start()
    {
        //target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        /*
        desiredPosition = target.position + offset;
        smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPostion;

        transform.LookAt(target);
        */
        
        yaw += cameraSpeedH * Input.GetAxis("Mouse X");
        pitch -= cameraSpeedV * Input.GetAxis("Mouse Y");
        if(pitch < -90.0 ) { pitch = -90.0f; }
        else if(pitch > 90.0) { pitch = 90.0f; }
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        

    }
}