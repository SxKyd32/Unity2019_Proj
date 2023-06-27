using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotate : MonoBehaviour
{
    public WheelCollider Wheel; // 获取车轮模型
    private float a;    // 车轮的旋转角度


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = Wheel.transform.rotation * Quaternion.Euler(a, 0, -90);
        a += Wheel.rpm * 360 * Time.deltaTime / 60;
    }
}
