using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveOnTrigger : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entetred");
    }
}
