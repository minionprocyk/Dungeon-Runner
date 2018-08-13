using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseGameEventsIfValueLessThanOrEqualTo : MonoBehaviour {
    public IntegerVariable integerVariable;
    public int value;
    public GameEvent[] gameEvents;
    
	
	// Update is called once per frame
	void Update () {
	    if(integerVariable.RuntimeValue <= value)
        {
            foreach(GameEvent ge in gameEvents)
            {
                ge.Raise();
            }
        }	
	}
}
