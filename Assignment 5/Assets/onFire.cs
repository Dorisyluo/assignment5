using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onFire : MonoBehaviour
{
    public ParticleSystem fire;
    public static bool firing = true;
    // Start is called before the first frame update
    void Start()
    {
        //fire.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        fire.Play(firing);
    }
    public static void setfire()
    {
        firing = true;
    }
}
