using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public Camera FixAngle;

    public Camera fix1;
    public Camera fix2;
    public Camera fix3;

    private Camera activeFixPos;

    private bool isFixedAngle = true;

    // Start is called before the first frame update
    void Start()
    {
        activeFixPos = fix1;

        FixAngle.enabled = false;

        fix1.enabled = false;
        fix2.enabled = false;
        fix3.enabled = false;


        ////EVERYTHING IS OFF NOW.


        FixAngle.enabled = isFixedAngle;
        activeFixPos.enabled = !isFixedAngle;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            UpdateCamera();
            isFixedAngle = !isFixedAngle;
        }
    }

    private void UpdateCamera()
    {
        if (isFixedAngle)
        {
            FixAngle.enabled = false;
            activeFixPos.enabled = true;
        }
        else
        {
            activeFixPos.enabled = false;
            FixAngle.enabled = true;
        }
    }

    void UpdatePosCamera() {
        if (!isFixedAngle)
        {
            activeFixPos.enabled = true;
        }
    }

    public void Cam1()
    {
        activeFixPos.enabled = false;
        activeFixPos = fix1;
        UpdatePosCamera();
    }
    public void Cam2()
    {
        activeFixPos.enabled = false;
        activeFixPos = fix2;
        UpdatePosCamera();
    }
    public void Cam3()
    {
        activeFixPos.enabled = false;
        activeFixPos = fix3;
        UpdatePosCamera();
    }
}
