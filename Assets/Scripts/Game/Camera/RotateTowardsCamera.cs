using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsCamera : MonoBehaviour {

    [SerializeField]
    private Transform objectToRotate;
  

    void Update()
    {
        objectToRotate.rotation = Camera.main.transform.rotation;

    }
}
