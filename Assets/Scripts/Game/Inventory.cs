﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public PlayerInventory PlayerInventory;
    public Item item;
    private Rigidbody rigidbody;

    public void Start()
    {
        rigidbody = GetComponentInChildren<Rigidbody>();
       
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player collided");
        if(other.CompareTag("obtainable_item"))
        {
            //put it in player inventory
            PlayerInventory.gameItems.Add(item);
        }
    }

}
