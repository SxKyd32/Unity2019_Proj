using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spacewtos : MonoBehaviour
{
    Vector3 ObjScPos;
    public GameObject gb;
    Rect BoxRect;

    // Start is called before the first frame update
    void Start()
    {
        ObjScPos = Camera.main.WorldToScreenPoint(gb.transform.position);
        BoxRect = new Rect(ObjScPos.x, ObjScPos.y, 100, 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Box(BoxRect, "");
    }


}
