using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testAudio : MonoBehaviour
{
    public AudioSource a1;
    public AudioSource a2;

    // Start is called before the first frame update
    void Start()
    {
        a1.Play();
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 10, Screen.height / 10, Screen.width / 10, Screen.height / 10), "亮剑"))
            a2.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
