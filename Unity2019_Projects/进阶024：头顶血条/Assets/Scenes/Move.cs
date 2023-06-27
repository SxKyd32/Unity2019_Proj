using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject capsule;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        capsule.transform.Rotate(0, 0.8f, 0);
    }
}
