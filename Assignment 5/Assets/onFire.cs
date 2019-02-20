using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onFire : MonoBehaviour
{
    private int firestick = 0;
    public GameObject block1;
    public GameObject block2;

    ParticleSystem system
    {
        get
        {
            if (_CachedSystem == null)
                _CachedSystem = GetComponent<ParticleSystem>();
            return _CachedSystem;
        }
    }
    public ParticleSystem _CachedSystem;



    public bool includeChildren = false;


    int i = 0;

    private void Start()
    {
        system.Stop(true, ParticleSystemStopBehavior.StopEmitting);

    }
    public void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Firestick"))
        {
            other.gameObject.SetActive(false);
            firestick++;
            sticks.s++;
            block1.gameObject.SetActive(false);
            block2.gameObject.SetActive(false);
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Bonfire"))
        {
            if(Input.GetKey(KeyCode.F) && firestick == 3)
            {
                Debug.Log("bonfire");
                if (!_CachedSystem.isPlaying)
                {
                    Bonfire();
                    firestick--;
                    //sticks.s--;
                }
            }
        }
    }

    public void Bonfire()
    {
        system.Play(true);
    }
}
