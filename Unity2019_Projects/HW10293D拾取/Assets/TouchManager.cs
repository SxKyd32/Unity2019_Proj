using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    public Camera cam;
    private float timeHit = 0f;     // 用于控制点击的间隔

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeHit += Time.deltaTime;
        if (timeHit >= 0f)      // 此处控制间隔时间
        {
            if (Input.GetMouseButtonDown(0))
            {
                timeHit = 0f;
                RaycastHit hit;
                bool isHit = Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit, 100f);
                if (isHit)
                {
                    hit.collider.gameObject.SendMessage("OnTouched", SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
