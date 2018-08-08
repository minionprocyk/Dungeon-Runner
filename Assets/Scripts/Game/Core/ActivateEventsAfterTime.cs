using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ActivateEventsAfterTime : MonoBehaviour {

    [SerializeField]
    private float Timer;

    [SerializeField]
    private UnityEvent Event;

	
	// Update is called once per frame
	void Update () {
        Timer -= Time.deltaTime;
        if(Timer<=0)
        {
            Event.Invoke();
            this.enabled = false;
        }
	}
}
