using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAvoid : MonoBehaviour
{
    public GameObject gb1;
    public GameObject gb2;

    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(gb1.GetComponent<SphereCollider>(), gb2.GetComponent<SphereCollider>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
