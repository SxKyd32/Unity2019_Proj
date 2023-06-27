using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMovement : MonoBehaviour
{
    // Start is called before the first frame update

    float AD;
    float WS;
    public float speed = 1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AD = Input.GetAxis("Horizontal");//横轴

        WS = Input.GetAxis("Vertical");//纵轴

        this.gameObject.transform.Translate(new Vector3(AD * speed * Time.deltaTime , 0, WS * speed * Time.deltaTime));

        speed += 0.5f * Time.deltaTime;
    }
}
