using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestRotate : MonoBehaviour
{
    bool isRotate = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotate==true)
            transform.Rotate(0, 1, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        isRotate = true;
    }


}
