using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixAngleCam : MonoBehaviour
{
    public Vector3 offset;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position);
    }
}
