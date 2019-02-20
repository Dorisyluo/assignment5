using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
    private static bool onfire = false;
    public GameObject firewood;
    private void Start()
    {

    }

    private void Update()
    {
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //havefirestick.used();
            //onFire.setfire();
            Debug.Log("bonfire touched");
        }
    }
}


