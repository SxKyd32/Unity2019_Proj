using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRotate : MonoBehaviour
{
    bool isOK = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isOK == true)
            transform.Rotate(0, 1, 0);
    }

    public void isRotate()
    {
        isOK = true;
    }


}
