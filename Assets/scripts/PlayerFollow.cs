using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 Offset = new Vector3(0, 5, -1);

    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //add some number to the player position and assign it
        //new vector3 only the constructor part, no need to store
        transform.position = player.transform.position + Offset;
    }
}
