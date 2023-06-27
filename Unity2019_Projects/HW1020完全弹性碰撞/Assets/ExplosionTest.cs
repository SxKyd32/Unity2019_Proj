using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTest : MonoBehaviour
{
    public GameObject rayCastPoint;
    public Rigidbody[] cubeRb;
    float ExForce = 300f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            if(Physics.Raycast(ray,out raycastHit))
            {
                rayCastPoint.transform.position = raycastHit.point;
                // 添加爆炸力
                foreach(Rigidbody rigidbody in cubeRb)
                {
                    rigidbody.AddExplosionForce(ExForce, raycastHit.point, 5, 80, ForceMode.Force);
                } 
            }
        }
    }
}
