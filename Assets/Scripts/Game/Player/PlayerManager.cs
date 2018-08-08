using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public GameObject player;
    public static PlayerManager instance;
    private void Awake()
    {
        instance = this;
    }
}
