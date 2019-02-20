using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject restartmenu;

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
    // Start is called before the first frame update
    void Start()
    {
        restartmenu.SetActive(false);
            }

    // Update is called once per frame
    void Update()
    {
        if (system.isPlaying)
        {
            display();
        }

    }
    void display()
    {
        restartmenu.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
