using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    private int firestick = 0;
    public GameObject block1;
    public GameObject block2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(firestick == 3)
        {
            onFire.setfire();
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Firestick"))
        {
            other.gameObject.SetActive(false);
            firestick++;
            block1.gameObject.SetActive(false);
            block2.gameObject.SetActive(false);
        }
    }
}
