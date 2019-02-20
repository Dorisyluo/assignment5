using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arealight : MonoBehaviour
{
    public Light blinkinglight;
    public float waitingTime = 0.05f;
    IEnumerator Start()
    {
        while (true)
        {
            blinkinglight.enabled = !(blinkinglight.enabled); //toggle on/off the enabled property
            yield return new WaitForSeconds(waitingTime);
        }
    }
}
