using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class havefirestick : MonoBehaviour
{
    public static bool havestick = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void obtain()
    {
        havestick = true;
    }
    public static void used()
    {
        havestick = false;
    }
}
