using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour {

    
    public float ObjectDestroyTime;

    private void FixedUpdate()
    {
        ObjectDestroyTime -= Time.deltaTime;

        if (ObjectDestroyTime <= 0)
        {
            Destroy(this.gameObject);
        }
       
    }
}
