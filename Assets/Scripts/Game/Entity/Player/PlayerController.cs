using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerController : MonoBehaviour {

    [Range(0f, 1f)]
    public float ButtonHeldThreshold = 0.5f;
    private float _buttonHeld = 0f;
    [SerializeField]
    private GameObject InventoryMenu;
    private Player player;
    private void Start()
    {
        player = GetComponent<Player>();
    }
    //TODO: How to provide method as parameter in .NET
    private void PerformActionIfHeld( ) 
    {
        _buttonHeld += Time.deltaTime;
        if (_buttonHeld >= ButtonHeldThreshold)
        {
            Debug.Log("Button Held Action Here");
        }
    }
    // Update is called once per frame
    void Update () {
	    	
        if(Input.GetButtonDown("Inventory"))
        {
            InventoryMenu.SetActive(!InventoryMenu.activeSelf);
        }
        else if (Input.GetButtonDown("Ability1"))
        {
            Debug.Log("Casting ability one");
            player.CastAbility(0);
        }
        else if (Input.GetButtonDown("Ability2"))
        {
            player.CastAbility(1);
        }
        else if(Input.GetButton("Ability1"))
        {
            //Debug.Log("Ability1 start hold");
            _buttonHeld += Time.deltaTime;
            if(_buttonHeld>=ButtonHeldThreshold)
            {
                Debug.Log("Button Held Action Here");
                //Do ability targeting here?
            }
           
        }
        else
        {
            _buttonHeld = 0f;
        }
        
    }

}
