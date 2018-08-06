using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barHUD : MonoBehaviour {

    [SerializeField]
    private float fillValue = 1.0f;
    private int maxValue = 100;
    private int currentValue = 100;
    [SerializeField]
    private Slider bar;

    // Use this for initialization
    void Start () {
        fillValue = (float)currentValue / maxValue;
        bar.value = fillValue;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.X))
        {
            dealDamage(6);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            healDamage(10);
        }
    }

    void dealDamage(int damageValue)
    {
        currentValue -= damageValue;
        if(currentValue < 0) { currentValue = 0; }
        bar.value = (float)currentValue / maxValue;
    }

    void healDamage(int healValue)
    {
        currentValue += healValue;
        if(currentValue > maxValue) { currentValue = maxValue; }
        bar.value = (float)currentValue / maxValue;
    }
}
