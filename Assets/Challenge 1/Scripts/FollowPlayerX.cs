using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(10, 0, 0);
    private Vector3 rotate = new Vector3(0, -90, 0);

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(rotate);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
        
    }
}
