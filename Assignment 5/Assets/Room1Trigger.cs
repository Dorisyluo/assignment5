using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1Trigger : MonoBehaviour
{

    public GameObject camControllerObject;
    private CamController camController;
    // Start is called before the first frame update
    private void Start()
    {
        camController = camControllerObject.GetComponent<CamController>();

    }


    private void OnTriggerEnter(Collider other)
    {
        camController.Cam1();
        Debug.Log("triggered");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
