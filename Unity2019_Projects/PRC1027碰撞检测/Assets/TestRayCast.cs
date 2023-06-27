using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRayCast : MonoBehaviour
{
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position,transform.forward,out hit,100))
        {
            transform.Rotate(0, 1, 0);
            if (hit.collider.gameObject.tag == "Sphere")
            {
                hit.collider.gameObject.SendMessage("isRotate");
            }
        }    
    }
}
