using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class sticks: MonoBehaviour
{
    public static int s;

    Text stick;

    void Awake()
    {
        stick = GetComponent<Text>();
        s = 0;
    }


    void Update()
    {
        stick.text = "You have " + s + " Sticks";
    }
}