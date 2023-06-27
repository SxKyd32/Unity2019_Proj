using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            //镜头放大
            if (Camera.main.fieldOfView > 2)
                Camera.main.fieldOfView -= 2;
            if (Camera.main.orthographicSize >= 1)
                Camera.main.orthographicSize -= 0.5f;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            //镜头缩小
            if (Camera.main.fieldOfView <= 100)
                Camera.main.fieldOfView += 2;
            if (Camera.main.orthographicSize <= 20)
                Camera.main.orthographicSize += 0.5f;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            //向左
            transform.Rotate(0, 1000 * Time.deltaTime, 0, Space.Self);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            //向右
            transform.Rotate(0, -1000 * Time.deltaTime, 0, Space.Self);
        }
    }
}
