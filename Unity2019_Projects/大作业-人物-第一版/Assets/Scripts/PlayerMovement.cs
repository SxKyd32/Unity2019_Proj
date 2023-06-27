using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    float AD;
    float WS;
    public float speed = 1.0f;
    public float jumpHeight = 1.0f;

    public Animation pa;
    void Start()
    {
        //pa = this.GetComponent<Animation>();
        //pa.Play("WGS_Run_Front@Loop");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            
            if(this.transform.position.x > -1)
            {
                this.gameObject.transform.position = new Vector3(this.transform.position.x - 1, this.transform.position.y, this.transform.position.z);
                //Debug.Log("A");
            }
            
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            if(this.transform.position.x < 1)
            {
                this.gameObject.transform.position = new Vector3(this.transform.position.x + 1, this.transform.position.y, this.transform.position.z);
                //Debug.Log("D");
            }
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(this.transform.position.y == 0)
            {

                //this.gameObject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + jumpHeight, this.transform.position.z);
                pa.Play("Jump W Root");
                ///Debug.Log("Space");
            }
        }


    }
}
